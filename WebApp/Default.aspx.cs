using MonteCarloForecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public List<MonteCarloForecast.ForecastResult> forecast = new List<MonteCarloForecast.ForecastResult>();

    protected void Page_Load(object sender, EventArgs e)
    {
        startDate.SelectedDate = DateTime.Today;
        txtEstHighVelocity.Text = "10";
        txtEstLowVelocity.Text = "6";
        txtHighProb.Text = "1.0";
        txtHighRemainingStories.Text = "45";
        txtLowProb.Text = "1.0";
        txtLowRemainingStories.Text = "40";
        txtModelSize.Text = "100000";
        txtSamples.Text = "5,6,3,3,1,18,13,5";
        
    }

    protected void btnForecastHistory_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;
        int RemainingStoriesGuessLow = Convert.ToInt32(txtLowRemainingStories.Text);
        int RemainingStoriesGuessHigh = Convert.ToInt32(txtHighRemainingStories.Text);
        double SplitProbabilityLow = Convert.ToDouble(txtLowProb.Text);
        double SplitProbabilityHigh = Convert.ToDouble(txtHighProb.Text);
        int myInt;
        int[] samples = txtSamples.Text.ToCharArray().Where(x =>
int.TryParse(x.ToString(), out myInt)).Select(x =>
int.Parse(x.ToString())).ToArray();
        int modelSize = Convert.ToInt32(txtModelSize.Text);

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples);

        StringBuilder sb = new StringBuilder();

        foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        {
            sb.AppendLine(string.Format("{0}%\t{1} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        }

        TextBox1.Text = sb.ToString();


    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {
        //DateTime StartDt = startDate.SelectedDate.Date;
        //int RemainingStoriesGuessLow = Convert.ToInt32(txtLowRemainingStories.Text);
        //int RemainingStoriesGuessHigh = Convert.ToInt32(txtHighRemainingStories.Text);
        //double SplitProbabilityLow = Convert.ToDouble(txtLowProb.Text);
        //double SplitProbabilityHigh = Convert.ToDouble(txtHighProb.Text);
        //int modelSize = Convert.ToInt32(txtModelSize.Text);
        //int guessLow = Convert.ToInt32(txtEstLowVelocity.Text);
        //int guessHigh = Convert.ToInt32(txtEstHighVelocity.Text);

        //Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        //List<ForecastResult> results = f.fo

        //StringBuilder sb = new StringBuilder();

        //foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        //{
        //    sb.AppendLine(string.Format("{0}%\t{1} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        //}

        //TextBox1.Text = sb.ToString();

    }
}