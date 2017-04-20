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
        if (!IsPostBack)
        {
            startDate.SelectedDate = DateTime.Today;
            txtHighProb.Text = "1.0";
            txtLowProb.Text = "1.0";
            txtModelSize.Text = "100000";
            ToggleForecastTypeView(RadioButtonList1.SelectedValue);

        }


    }

    #region Properties
   

    private int RemainingStoriesGuessLow
    {
        get
        {
            return Convert.ToInt32(txtLowRemainingStories.Text);
        }
    }

    private int RemainingStoriesGuessHigh
    {
        get
        {
            return Convert.ToInt32(txtHighRemainingStories.Text);
        }
    }

    private double SplitProbabilityLow
    {
        get
        {
            return Convert.ToDouble(txtLowProb.Text);
        }
    }

    private double SplitProbabilityHigh
    {
        get
        {
            return Convert.ToDouble(txtHighProb.Text);
        }
    }

    private int LowStoriesPerWeek
    {
        get
        {
            return Convert.ToInt32(txtEstLowVelocity.Text);
        }
    }

    private int HighStoriesPerWeek
    {
        get
        {
            return Convert.ToInt32(txtEstHighVelocity.Text);
        }
    }

    private int ModelSize
    {
        get
        {
            return Convert.ToInt32(txtModelSize.Text);
        }
    }

    private int[] Samples
    {
        get
        {
            return txtSamples.Text.Split(','.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();
        }
    }

    #endregion

    protected void btnForecastHistory_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(ModelSize, Samples, AverageTypeEnum.Simple);

        TextBox1.Text = FormatSimpleHistory(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh, results, AverageTypeEnum.Simple.ToString());

    }

    private string FormatSimpleHistory(DateTime StartDt, int RemainingStoriesGuessLow, int RemainingStoriesGuessHigh,
        double SplitProbabilityLow, double SplitProbabilityHigh, List<ForecastResult> results, string forecastType)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(string.Format("{0} Forecast based on history", forecastType));
        sb.AppendLine(string.Format("Forecast as of    -- {0}", StartDt.ToShortDateString()));
        sb.AppendLine(string.Format("Remaining Stories -- Low Guess: {0}, High Guess: {1}", RemainingStoriesGuessLow,
            RemainingStoriesGuessHigh));
        sb.AppendLine(string.Format("Cadence History   -- {0}", txtSamples.Text));
        sb.AppendLine(string.Format("Split Prob.       -- Low Guess: {0}, High Guess: {1}", SplitProbabilityLow,
            SplitProbabilityHigh));
        sb.AppendLine();


        foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        {
            sb.AppendLine(string.Format("{0:000}%\t{1:00} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        }
        return sb.ToString();
    }

    private static string FormatGuessHistory(DateTime StartDt, int RemainingStoriesGuessLow,
        int RemainingStoriesGuessHigh, int lowStoriesPerWeek, int highStoriesPerWeek, double SplitProbabilityLow,
        double SplitProbabilityHigh, List<ForecastResult> results)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Forecast based on velocity guess");
        sb.AppendLine(string.Format("Forecast as of    -- {0}", StartDt.ToShortDateString()));
        sb.AppendLine(string.Format("Remaining Stories -- Low Guess: {0}, High Guess: {1}", RemainingStoriesGuessLow,
            RemainingStoriesGuessHigh));
        sb.AppendLine(string.Format("Weekly Cadence    -- Low Guess: {0}, High Guess: {1}", lowStoriesPerWeek,
            highStoriesPerWeek));
        sb.AppendLine(string.Format("Split Prob.       -- Low Guess: {0}, High Guess: {1}", SplitProbabilityLow,
            SplitProbabilityHigh));
        sb.AppendLine();

        foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        {
            sb.AppendLine(string.Format("{0:000}%\t{1:00} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        }
        return sb.ToString();
    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(ModelSize, LowStoriesPerWeek,HighStoriesPerWeek);

        TextBox1.Text = FormatGuessHistory(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, LowStoriesPerWeek, HighStoriesPerWeek, SplitProbabilityLow, SplitProbabilityHigh, results);

    }

    protected void btnForecastHistoryWeighted_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(ModelSize, Samples, AverageTypeEnum.Weighted);

        TextBox1.Text = FormatSimpleHistory(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh, results, AverageTypeEnum.Weighted.ToString());

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToggleForecastTypeView(RadioButtonList1.SelectedValue);
    }

    protected void ToggleForecastTypeView(string mode)
    {
        bool historyMode = mode == "History";

        GuessForecastElements.Visible = !historyMode;
        HistoryForecastElements.Visible = historyMode;
    }
}