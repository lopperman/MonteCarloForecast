using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloForecast
{
    public enum ForecastTypeEnum
    {
        HighLowGuess, 
        Simple, 
        Weighted
    }

    public class Burndown
    {


        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public int RemainingStoriesLow { get; set; }
        public int RemainingStoriesHigh { get; set; }
        public double SplitRateLow { get; set; }
        public double SplitRateHigh { get; set; }
        public int VelocityGuessLow { get; set; }
        public int VelocityGuessHigh { get; set; }
        public int[] Samples { get; set; }
        public ForecastTypeEnum ForecastType { get; set; }

        public Forecast forecast = null;
        private List<ForecastResult> results = null;

        private int numberWeeks = 0;
        private SortedList<DateTime,int> IdealStories { get; set; }


        public Burndown(ForecastTypeEnum forecastType, DateTime startDt, DateTime endDt, int remainingStoriesLow, int remainingStoriesHigh, double splitRateLow, double splitRateHigh, int velocityGuessLow, int velocityGuessHigh, int[] samples)
        {
            ForecastType = forecastType;
            StartDt = startDt;
            EndDt = endDt;
            RemainingStoriesLow = remainingStoriesLow;
            RemainingStoriesHigh = remainingStoriesHigh;
            SplitRateLow = splitRateLow;
            SplitRateHigh = splitRateHigh;
            VelocityGuessLow = velocityGuessLow;
            VelocityGuessHigh = velocityGuessHigh;

            CreateForecast();
            CreateIdeal();
        }

        private void CreateIdeal()
        {
            TimeSpan ts = EndDt.Date.Subtract(StartDt.Date);
            numberWeeks = (int) (ts.TotalDays/7);

            int idealPerWeek = RemainingStoriesHigh/numberWeeks;

            IdealStories = new SortedList<DateTime, int>();

            DateTime start = StartDt.Date.AddDays(7);
            while (start <= EndDt.Date)
            {
                IdealStories.Add(start,idealPerWeek);
                start = start.AddDays(7);
            }

            if (IdealStories.Values.Sum() < RemainingStoriesHigh)
            {
                start = StartDt.Date.AddDays(7);
                while (true)
                {
                    IdealStories[start] = idealPerWeek + 1;
                    start = start.AddDays(7);
                    if (IdealStories.Values.Sum() >= RemainingStoriesHigh)
                    {
                        break;
                    }
                }


            }
        }


        private void CreateForecast()
        {
            if (ForecastType == ForecastTypeEnum.HighLowGuess)
            {
                forecast = new Forecast(StartDt.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                results = forecast.GetForecastBasedOnHighLowGuess(100000, VelocityGuessLow, VelocityGuessHigh);
            }
            else if (ForecastType == ForecastTypeEnum.Simple)
            {
                forecast = new Forecast(StartDt.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                results = forecast.GetForecastBasedOnHistory(100000, Samples, AverageTypeEnum.Simple);
            }
            else if (ForecastType == ForecastTypeEnum.Weighted)
            {
                forecast = new Forecast(StartDt.Date, RemainingStoriesLow, RemainingStoriesHigh, SplitRateLow, SplitRateHigh);
                results = forecast.GetForecastBasedOnHistory(100000, Samples, AverageTypeEnum.Weighted);
            }
        }
    }
}
