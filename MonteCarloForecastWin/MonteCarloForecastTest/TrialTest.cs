using MonteCarloForecast;
using NUnit.Framework;
using System;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class TrialTest
    {
        Trial trial = null;
        Random rnd = new Random();

        [OneTimeSetUp]
        public void setup()
        {
            trial = new Trial(rnd);
        }

        [OneTimeTearDown]
        public void teardown()
        {
            trial = null;
        }

        [Test]
        public void initTrialWithRandom()
        {
            trial = new Trial(rnd);
            Assert.IsNotNull(trial.Rnd);
        }

        [Test]
        public void StartDateProp()
        {
            DateTime dt = DateTime.Today.Date;
            trial.StartDate = dt;
            Assert.AreEqual(dt, trial.StartDate);
        }

        [Test]
        public void SetLowHighStoryEstimates()
        {
            int lowEstimate = 39;
            int highEstimate = 44;
            trial.SetRemainingStoryEstimates(lowEstimate, highEstimate);
            Assert.AreEqual(lowEstimate, trial.LowStoryRemainingEstimate);
            Assert.AreEqual(highEstimate, trial.HighStoryRemainingEstimate);
        }

        [Test]
        public void HighLessThanLowRemainingStoryEstimateThrowsException()
        {
            int lowEstimate = 40;
            int highEstimate = 39;
            Assert.Throws<ArgumentException>(() => trial.SetRemainingStoryEstimates(lowEstimate, highEstimate));
        }

        [Test]
        public void SetLowHighSplitProbability()
        {
            double low = 1.0;
            double high = 1.1;
            trial.SetSplitProbabilities(low, high);
            Assert.AreEqual(low, trial.LowSplitProbability);
            Assert.AreEqual(high, trial.HighSplitProbability);

            low = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => trial.SetSplitProbabilities(low, high));

            low = 1.5;
            high = 1.45;
            Assert.Throws<ArgumentException>(() => trial.SetSplitProbabilities(low, high));
        }

        [Test]
        public void GenerateTotalStoryCountForTrial()
        {
            int lowRemainStoryGuess = 35;
            int highRemainStoryGuess = 40;
            double splitProbabilityLow = 1.0;
            double splitProbabilityHigh = 1.0;
            trial.SetRemainingStoryEstimates(lowRemainStoryGuess, highRemainStoryGuess);
            trial.SetSplitProbabilities(splitProbabilityLow, splitProbabilityHigh);

            for (int i = 0; i < 10000; i ++)
            {
                int storyCount = trial.GenerateStoryCountForTrial();
                Assert.IsTrue(storyCount >= lowRemainStoryGuess && storyCount <= highRemainStoryGuess);
            }

            splitProbabilityLow = 1.0;
            splitProbabilityHigh = 2.0;
            trial.SetSplitProbabilities(splitProbabilityLow, splitProbabilityHigh);

            for (int i = 0; i < 10000; i++)
            {
                int storyCount = trial.GenerateStoryCountForTrial();

                Assert.IsTrue(storyCount >= lowRemainStoryGuess);
                Assert.IsTrue(storyCount <= (highRemainStoryGuess + (highRemainStoryGuess * splitProbabilityHigh)));
            }
        }

        [Test]
        public void GenerateTrialWithHistorySamples()
        {
            trial = new Trial(rnd);
            trial.StartDate = DateTime.Today.Date;
            trial.SetRemainingStoryEstimates(40, 45);
            trial.SetSplitProbabilities(1.0, 1.0);
            int[] samples = new int[] { 3, 6, 6, 1, 18, 13, 5, 4 };
            TrialResult result = trial.RunTrialBasedOnHistoricSamples(samples);
            Assert.IsNotNull(result);

        }

        public void GenerateTrialWithHighLowGuess()
        {
            trial = new Trial(rnd);
            trial.StartDate = DateTime.Today.Date;
            trial.SetRemainingStoryEstimates(40, 45);
            trial.SetSplitProbabilities(1.0, 1.0);
            int lowGuess = 5;
            int highGuess = 10;
            TrialResult result = trial.RunTrialBasedOnGuess(lowGuess, highGuess);
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(6, result.Results.Count);
            Assert.LessOrEqual(10, result.Results.Count);
        }

    }
}
