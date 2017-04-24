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
        if (!IsPostBack)
        {
            startDate.SelectedDate = DateTime.Today;
            endDate.SelectedDate = DateTime.Today;
            forecastDate.SelectedDate = DateTime.Today;
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

    private DateTime ForecastFromDate
    {
        get { return this.forecastDate.SelectedDate.Date; }
    }

    private DateTime ForecastStartDate
    {

        get { return this.endDate.SelectedDate.Date; }
                    
    }

    private DateTime IdealEndDate
    {
        get { return this.endDate.SelectedDate.Date; }
    }

    #endregion


    protected void btnForecastHistory_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(ModelSize, Samples, AverageTypeEnum.Simple);
    }

    protected void btnForecastHistoryWeighted_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(ModelSize, Samples, AverageTypeEnum.Weighted);


    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(ModelSize, LowStoriesPerWeek, HighStoriesPerWeek);
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