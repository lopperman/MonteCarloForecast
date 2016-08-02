using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloForecast
{
    public class Forecast
    {
        public DateTime StartDt { get; set; }
        public int RemainingStoriesGuessLow { get; set; }
        public int RemainingStoriesGuessHigh { get; set; }
        public double SplitProbabilityLow { get; set; }
        public double SplitProbabilityHigh { get; set; }

        public Forecast(DateTime startDate, int remainingStoriesLowGuess, int remainingStoriesHighGuess, double splitProbabilityLow, double splitProbabilityHigh)
        {
            StartDt = startDate;
            RemainingStoriesGuessLow = remainingStoriesLowGuess;
            RemainingStoriesGuessHigh = remainingStoriesHighGuess;
            SplitProbabilityLow = splitProbabilityLow;
            SplitProbabilityHigh = splitProbabilityHigh;
        }
    }
}
