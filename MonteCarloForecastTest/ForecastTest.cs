using MonteCarloForecast;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class ForecastTest
    {
        [Test]
        public void ForecastConstructorAndProperties()
        {
            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.25;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            Assert.AreEqual(StartDt, f.StartDt);
            Assert.AreEqual(RemainingStoriesGuessLow, f.RemainingStoriesGuessLow);
            Assert.AreEqual(RemainingStoriesGuessHigh, f.RemainingStoriesGuessHigh);
            Assert.AreEqual(SplitProbabilityLow, f.SplitProbabilityLow);
            Assert.AreEqual(SplitProbabilityHigh, f.SplitProbabilityHigh);

        }

        [Test]
        public void GetForecastBasedOnHistory()
        {
            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int[] samples = new int[] { 5, 6, 3, 1, 18, 13, 5, 4 };
            int modelSize = 100000;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            Assert.IsNotNull(f.Rnd);

            List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Simple);



        }

        [Test]
        public void GetForecastBasedOnHistoryWeightedAverage()
        {
            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int[] samples = new int[] { 5, 6, 3, 1, 18, 13, 5, 4 };
            int modelSize = 100000;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            Assert.IsNotNull(f.Rnd);

            List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Weighted);



        }

        [Test]
        public void GetForecastBasedOnGuessingVelocity()
        {
            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 40;
            int RemainingStoriesGuessHigh = 45;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int modelSize = 100000;
            int lowVelocityGuess = 6;
            int highVelocityGuess = 10;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            List<ForecastResult> results = f.GetForecastBasedOnHighLowGuess(modelSize, lowVelocityGuess, highVelocityGuess);

        }

        [Test]
        public void ForecastComparison()
        {
            DateTime StartDt = DateTime.Now;
            int RemainingStoriesGuessLow = 30;
            int RemainingStoriesGuessHigh = 35;
            double SplitProbabilityLow = 1.0;
            double SplitProbabilityHigh = 1.0;
            int[] samples = new int[] { 5, 6, 3, 3, 1, 18, 13, 5 };
            int modelSize = 100000;

            Forecast f = new Forecast(StartDt, RemainingStoriesGuessLow, RemainingStoriesGuessHigh, SplitProbabilityLow, SplitProbabilityHigh);

            List<ForecastResult> results = f.GetForecastBasedOnHistory(modelSize, samples, AverageTypeEnum.Simple);




        }

    }
}
