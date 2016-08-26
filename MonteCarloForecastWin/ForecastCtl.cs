using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonteCarloForecast;
using System.Text.RegularExpressions;

namespace MonteCarloForecastWin
{


    public partial class ForecastCtl : UserControl
    {
        public delegate void GetHistoricSamplesDelegate(object sender, HistoricSamplesEventArgs args);
        public event GetHistoricSamplesDelegate OnGetHistoricSamples;

        List<string> errors = new List<string>();

        public ForecastCtl()
        {
            InitializeComponent();
            cmdSamplesForecast.Click += cmdSamplesForecast_Click;
            cmdHighLowGuessForecast.Click += cmdHighLowGuessForecast_Click;
            cmdSamplesForecastWeighted.Click += cmdSamplesForecastWeighted_Click;
        }

        private void cmdHighLowGuessForecast_Click(object sender, EventArgs e)
        {
            errors.Clear();

            if (ParametersValid && ForecastLowHighParametersValid)
            {
                Forecast forecast = new Forecast(dtStartDt.Value.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                List<ForecastResult> results = forecast.GetForecastBasedOnHighLowGuess(Convert.ToInt32(numPermutations.Value), VelocityGuessLow, VelocityGuessHigh);

                RenderResults("LowHighGuess", results);

            }
            else
            {
                MessageBox.Show(BuildErrorMessage());
            }
        }

        private void cmdSamplesForecast_Click(object sender, EventArgs e)
        {
            errors.Clear();
            if (ParametersValid && SamplesValid)
            {
                Forecast forecast = new Forecast(dtStartDt.Value.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                List<ForecastResult> results = forecast.GetForecastBasedOnHistory(Convert.ToInt32(numPermutations.Value), Samples, AverageTypeEnum.Simple);

                RenderResults("Samples - Simple Average", results);
            }
            else
            {
                MessageBox.Show(BuildErrorMessage());
            }

        }

        private void RenderResults(string type, List<ForecastResult> results)
        {
            Font fontParms = new Font("Ariel", 12f, FontStyle.Bold);
            Color colorParms = Color.LightGray;

            Font fontResults = new Font("Ariel", 12f, FontStyle.Regular);

            Color colorGreen = Color.LightGreen;
            Color colorYellow = Color.LemonChiffon;
            Color colorRed = Color.LightSalmon;

            rtbResults.SelectionFont = fontParms;
            rtbResults.SelectionBackColor = colorParms;

            rtbResults.AppendText(string.Format("{0}{1}", "Parameters", Environment.NewLine));
            rtbResults.AppendText(string.Format("Forecast Type: {0}{1}", type, Environment.NewLine));
            rtbResults.AppendText(string.Format("Start Date: {0}, Model Permutations: {1}{2}", dtStartDt.Value.Date.ToShortDateString(), Convert.ToInt32(numPermutations.Value), Environment.NewLine));
            rtbResults.AppendText(string.Format("Remaining Stories: Low - {0}, High - {1}{2}", RemainingStoriesLow, RemainingStoriesHigh, Environment.NewLine));
            rtbResults.AppendText(string.Format("Split Rate: Low - {0}, High - {1}{2}", SplitRateLow, SplitRateHigh, Environment.NewLine));

            if (type == "Samples")
            {
                rtbResults.AppendText(string.Format("Samples: {0}{1}", txtSamples.Text, Environment.NewLine));
            }
            else
            {
                rtbResults.AppendText(string.Format("Estimated Velocity: Low - {0}, High - {1}{2}", VelocityGuessLow, VelocityGuessHigh, Environment.NewLine));
            }

            rtbResults.AppendText(Environment.NewLine);

            results = results.OrderByDescending(x => x.Date).OrderByDescending(x => x.Likelihood).ToList();

            rtbResults.Font = fontResults;

            foreach (ForecastResult result in results)
            {
                if (result.Likelihood >= 85)
                {
                    rtbResults.SelectionBackColor = colorGreen;
                    rtbResults.AppendText(BuildResultLine(result));
                }
                else if (result.Likelihood >= 50)
                {
                    rtbResults.SelectionBackColor = colorYellow;
                    rtbResults.AppendText(BuildResultLine(result));
                }
                else
                {
                    rtbResults.SelectionBackColor = colorRed;
                    rtbResults.AppendText(BuildResultLine(result));
                }
            }
            rtbResults.AppendText(Environment.NewLine);

            rtbResults.ScrollToCaret();

        }

        private string BuildResultLine(ForecastResult result)
        {
            string date = string.Format("{0:00}/{1:00}/{2:0000}", result.Date.Month, result.Date.Day, result.Date.Year);

            return string.Format("{0:000}%{1}{2:00} Weeks{1}{3}{4}", result.Likelihood, "\t", result.Weeks, date, Environment.NewLine);
        }

        private string BuildErrorMessage()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string error in errors)
            {
                sb.AppendLine(error);
            }

            return sb.ToString();
        }

        private bool ParametersValid
        {
            get
            {
                bool ret = true;
                if (RemainingStoriesLow > RemainingStoriesHigh)
                {
                    ret = false;
                    errors.Add("Remaining stories Low cannot be greater than Remaining stories High.");
                }
                if (RemainingStoriesLow <= 0 || RemainingStoriesHigh <= 0)
                {
                    ret = false;
                    errors.Add("Remaining stories low/high must be greater than 0 (zero).");
                }

                if (SplitRateLow > SplitRateHigh)
                {
                    ret = false;
                    errors.Add("Split Rate Low cannot be greater than Split Rate High.");
                }
                if (SplitRateLow < 1d)
                {
                    ret = false;
                    errors.Add("Split Rate Low cannot be less than 1.00.");
                }

                return ret;
            }
        }

        private bool ForecastLowHighParametersValid
        {
            get
            {
                bool ret = true;

                if (VelocityGuessLow > VelocityGuessHigh)
                {
                    ret = false;
                    errors.Add("Velocity Guess Low cannot be greater than Velocity Guess High.");
                }
                if (VelocityGuessLow <= 0)
                {
                    ret = false;
                    errors.Add("Velocity Guess Low cannot be less than 1.");
                }

                return ret;
            }
        }

        private bool SamplesValid
        {
            get
            {
                bool ret = true;

                if (Samples == null || Samples.Length < 7)
                {
                    ret = false;
                    errors.Add("You must enter 7 or more historic values as comma-separated integers.");
                }
                else
                {
                    txtSamples.Text = string.Join(", ", Samples);
                }

                return ret;

            }
        }

        private int RemainingStoriesLow
        {
            get
            {
                return Convert.ToInt32(numRemainingLowGuess.Value);
            }
        }

        private int RemainingStoriesHigh
        {
            get
            {
                return Convert.ToInt32(numRemainingHighGuess.Value);
            }
        }

        private int VelocityGuessLow
        {
            get
            {
                return Convert.ToInt32(numLowVelocityGuess.Value);
            }
        }

        private int VelocityGuessHigh
        {
            get
            {
                return Convert.ToInt32(numHighVelocityGuess.Value);
            }
        }

        private double SplitRateLow
        {
            get
            {
                return Convert.ToDouble(numSplitRateLow.Value);
            }
        }

        private double SplitRateHigh
        {
            get
            {
                return Convert.ToDouble(numSplitRateHigh.Value);
            }
        }


        private int[] Samples
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtSamples.Text)) return new int[] { 0 };

                return SanitizeSamples(txtSamples.Text);
            }
        }

        private int[] SanitizeSamples(string text)
        {
            string[] array = text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<int> list = new List<int>();

            Regex digits = new Regex(@"[^\d]");

            for (int i = 0; i < array.Length; i++)
            {
                string test = digits.Replace(array[i], "");
                if (!string.IsNullOrWhiteSpace(test))
                {
                    int sample = 0;
                    if (Int32.TryParse(test, out sample)) list.Add(sample);
                }
            }

            return list.ToArray();

        }

        private void cmdSamplesForecastWeighted_Click(object sender, EventArgs e)
        {
            errors.Clear();
            if (ParametersValid && SamplesValid)
            {
                Forecast forecast = new Forecast(dtStartDt.Value.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                List<ForecastResult> results = forecast.GetForecastBasedOnHistory(Convert.ToInt32(numPermutations.Value), Samples, AverageTypeEnum.Weighted);

                RenderResults("Samples - Weighted Average", results);
            }
            else
            {
                MessageBox.Show(BuildErrorMessage());
            }

        }

        private void txtSamples_DoubleClick(object sender, EventArgs e)
        {
            if (OnGetHistoricSamples != null)
            {
                HistoricSamplesEventArgs args = new HistoricSamplesEventArgs();
                OnGetHistoricSamples(this, args);
                if (args != null)
                {
                    this.txtSamples.Text = string.Join(",", args.Samples);
                }
            }            
        }

        private void cmdGetHistoricSamples_Click(object sender, EventArgs e)
        {
            OnGetHistoricSamples?.Invoke(this, new HistoricSamplesEventArgs());
        }
    }

    public class HistoricSamplesEventArgs : EventArgs
    {
        /// <summary>
        /// Historic samples, with oldest samples first
        /// </summary>
        public int[] Samples { get; set; }
    }

}
