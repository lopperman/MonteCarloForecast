using System;

namespace MonteCarloForecast
{
    public class ForecastResult
    {
        public ForecastResult(decimal likelihood, int weeks, DateTime date)
        {
            Likelihood = likelihood;
            Weeks = weeks;
            Date = date;
        }

        public decimal Likelihood { get; set; }
        public int Weeks { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return string.Format("{0}%::Weeks {1}: Date: {2}", Likelihood, Weeks, Date.ToShortDateString());
        }
    }
}
