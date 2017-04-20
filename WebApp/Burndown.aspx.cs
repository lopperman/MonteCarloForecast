using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MonteCarloForecast;

public partial class Burndown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    }

    protected void btnForecastHistoryWeighted_Click(object sender, EventArgs e)
    {

    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}