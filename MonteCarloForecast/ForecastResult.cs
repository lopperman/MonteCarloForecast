using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
