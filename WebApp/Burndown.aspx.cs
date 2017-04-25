using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
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

        Chart(results);
    }

    protected void btnForecastHistoryWeighted_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHistory(ModelSize, Samples, AverageTypeEnum.Weighted);

        Chart(results);

    }

    protected void btnForecastGuess_Click(object sender, EventArgs e)
    {
        DateTime StartDt = startDate.SelectedDate.Date;

        Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

        List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(ModelSize, LowStoriesPerWeek, HighStoriesPerWeek);

        Chart(results);

    }

    protected void Chart(List<ForecastResult> results)
    {
        
        while (true)
        {
            Chart1.Series.Remove(Chart1.Series.FirstOrDefault());
            if (Chart1.Series.Count == 0)
            {
                break;
            }
        }

        Series series = CreateSeries("count", SeriesChartType.Line, 2, Color.Blue, ChartDashStyle.Solid,
    ChartValueType.DateTime, "Dev Complete");
        Chart1.Series.Add(series);
        Chart1.Series["count"].Points.DataBind(results, "Weeks", "Likelihood", "Tooltip=Weeks");

        Chart1.Visible = true;


    }

    private Series CreateSeries(string name, SeriesChartType chartType, int borderWidth, Color color, ChartDashStyle borderDashStyle,
    ChartValueType valueType, string legendText)
    {
        Series series = new Series(name);
        series.ChartType = chartType;
        series.BorderWidth = borderWidth;
        series.BorderDashStyle = borderDashStyle;
        series.Color = color;
        series.XValueType = valueType;
        series.IsValueShownAsLabel = true;
        series.LegendText = legendText;

        return series;
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