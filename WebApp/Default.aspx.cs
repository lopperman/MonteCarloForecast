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
            txtEstHighVelocity.Text = "10";
            txtEstLowVelocity.Text = "6";
            txtHighProb.Text = "1.0";
            txtHighRemainingStories.Text = "45";
            txtLowProb.Text = "1.0";
            txtLowRemainingStories.Text = "40";
            txtModelSize.Text = "100000";
            txtSamples.Text = "5,6,3,3,1,18,13,5";
        }


    }

    protected void btnForecastHistory_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;
        int RemainingStoriesGuessLow = Convert.ToInt32(txtLowRemainingStories.Text);
        int RemainingStoriesGuessHigh = Convert.ToInt32(txtHighRemainingStories.Text);
        double SplitProbabilityLow = Convert.ToDouble(txtLowProb.Text);
        double SplitProbabilityHigh = Convert.ToDouble(txtHighProb.Text);
        int[] samples = txtSamples.Text.Split(','.ToString().ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();
        int modelSize = Convert.ToInt32(txtModelSize.Text);

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Simple);

        StringBuilder sb = new StringBuilder();

        foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        {
            sb.AppendLine(string.Format("{0:000}%\t{1:00} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        }

        TextBox1.Text = sb.ToString();


    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;
        int RemainingStoriesGuessLow = Convert.ToInt32(txtLowRemainingStories.Text);
        int RemainingStoriesGuessHigh = Convert.ToInt32(txtHighRemainingStories.Text);
        double SplitProbabilityLow = Convert.ToDouble(txtLowProb.Text);
        double SplitProbabilityHigh = Convert.ToDouble(txtHighProb.Text);
        int lowStoriesPerWeek = Convert.ToInt32(txtEstLowVelocity.Text);
        int highStoriesPerWeek = Convert.ToInt32(txtEstHighVelocity.Text);
        int modelSize = Convert.ToInt32(txtModelSize.Text);

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(modelSize, lowStoriesPerWeek,highStoriesPerWeek);

        StringBuilder sb = new StringBuilder();

        foreach (ForecastResult fr in results.OrderByDescending(x => x.Date).ToList())
        {
            sb.AppendLine(string.Format("{0:000}%\t{1:00} Weeks\t{2}", fr.Likelihood, fr.Weeks, fr.Date.ToShortDateString()));
        }

        TextBox1.Text = sb.ToString();

    }
}