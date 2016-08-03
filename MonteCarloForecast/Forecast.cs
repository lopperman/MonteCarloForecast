using System;
using System.Collections.Generic;

namespace MonteCarloForecast
{
    public class Forecast
    {
        Random rnd = new Random();

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

        public Random Rnd
        {
            get
            {
                return rnd;
            }
        }

        public List<ForecastResult> GetForecastBasedOnHistory(int modelSize, int[] samples)
        {

            double[] weeksToZero = new double[modelSize];

            for (int i = 0; i < modelSize; i ++)
            {
                Trial trial = new Trial(Rnd);
                trial.LowStoryRemainingEstimate = RemainingStoriesGuessLow;
                trial.HighStoryRemainingEstimate = RemainingStoriesGuessHigh;
                trial.LowSplitProbability = SplitProbabilityLow;
                trial.HighSplitProbability = SplitProbabilityHigh;
                trial.StartDate = StartDt;
                TrialResult trialResult = trial.RunTrialBasedOnHistoricSamples(samples);
                weeksToZero[i] = trialResult.Results.Count - 1;

                if (i > modelSize) break;
            }

            return BuildForecastResults(weeksToZero);
        }

        public List<ForecastResult> GetForecastBasedOnHighLowGuess(int modelSize, int lowStoriesPerWeek, int highStoriesPerWeek)
        {

            double[] weeksToZero = new double[modelSize];

            for (int i = 0; i < modelSize; i++)
            {
                Trial trial = new Trial(Rnd);
                trial.LowStoryRemainingEstimate = RemainingStoriesGuessLow;
                trial.HighStoryRemainingEstimate = RemainingStoriesGuessHigh;
                trial.LowSplitProbability = SplitProbabilityLow;
                trial.HighSplitProbability = SplitProbabilityHigh;
                trial.StartDate = StartDt;
                TrialResult trialResult = trial.RunTrialBasedOnGuess(lowStoriesPerWeek,highStoriesPerWeek);
                weeksToZero[i] = trialResult.Results.Count - 1;

                if (i > modelSize) break;
            }

            return BuildForecastResults(weeksToZero);
        }


        public List<ForecastResult> BuildForecastResults(double[] array)
        {
            List<ForecastResult> ret = new List<ForecastResult>();

            List<double> previousValues = new List<double>();
            previousValues.Add(0);

            int i = 0;

            int weeks = 1;
            while (true)
            {
                double results = MathUtilities.PercentileRank(array, weeks);

                ret.Add(new ForecastResult(Convert.ToDecimal(results), weeks, StartDt.AddDays(7 * weeks)));

                weeks += 1;

                if (results >= 100)
                {
                    break;
                }

            }

            return ret;
        }
    }
}
