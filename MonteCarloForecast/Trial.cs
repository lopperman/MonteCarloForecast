using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloForecast
{
    public class Trial
    {
        public Random Rnd { get; private set; }
        public DateTime StartDate { get; set; }
        public int LowStoryRemainingEstimate { get; set; }
        public int HighStoryRemainingEstimate { get; set; }
        public double LowSplitProbability { get; set; }
        public double HighSplitProbability { get; set; }

        public Trial(Random random)
        {
            this.Rnd = random;
        }

        public void SetRemainingStoryEstimates(int lowStoryRemainingEstimate, int highStoryRemainingEstimate)
        {
            if (highStoryRemainingEstimate < lowStoryRemainingEstimate)
            {
                throw new ArgumentException("highStoryRemainingEstimate must be greater than or equal to lowStoryRemainingEstimate", "highStoryRemainingEstimate");
            }

            LowStoryRemainingEstimate = lowStoryRemainingEstimate;
            HighStoryRemainingEstimate = highStoryRemainingEstimate;
        }

        public void SetSplitProbabilities(double lowSplitProbability, double highSplitProbability)
        {
            if (highSplitProbability < lowSplitProbability)
            {
                throw new ArgumentException("highSplitProbability must be greater than or equal to lowSplitProbability", "highSplitProbability");
            }
            if (highSplitProbability <= 0 || lowSplitProbability <= 0)
            {
                throw new ArgumentOutOfRangeException("lowSplitProbability and highSplitProbability must be greater than zero (0).");
            }

            LowSplitProbability = lowSplitProbability;
            HighSplitProbability = highSplitProbability;
        }

        public int GenerateStoryCountForTrial()
        {
            double totStories = 0;

            totStories = Rnd.Next(LowStoryRemainingEstimate, HighStoryRemainingEstimate + 1);

            return Convert.ToInt32(Math.Ceiling(totStories + (totStories * SplitProbability())));
        }

        private double SplitProbability()
        {
            return Rnd.NextDouble() * (HighSplitProbability - LowSplitProbability);
        }

        public TrialResult RunTrialBasedOnHistoricSamples(int[] samples)
        {
            TrialResult trial = new TrialResult();

            int storiesForThisTrial = GenerateStoryCountForTrial();
            int remainingStoriesForThisTrial = storiesForThisTrial;
            DateTime processingDate = StartDate;

            trial.TotalStories = storiesForThisTrial;
            trial.AddResult(processingDate, storiesForThisTrial);

            while(remainingStoriesForThisTrial > 0)
            {
                processingDate = processingDate.AddDays(7);
                int storiesThisPeriod = samples[Rnd.Next(samples.Length)];
                remainingStoriesForThisTrial = remainingStoriesForThisTrial - storiesThisPeriod;
                if (remainingStoriesForThisTrial < 0) remainingStoriesForThisTrial = 0;
                trial.AddResult(processingDate, remainingStoriesForThisTrial);
            }

            return trial;
        }

        public TrialResult RunTrialBasedOnGuess(int lowStoriesPerWeekGuess, int highStoriesPerWeekGuess)
        {
            TrialResult trial = new TrialResult();

            int storiesForThisTrial = GenerateStoryCountForTrial();
            int remainingStoriesForThisTrial = storiesForThisTrial;
            DateTime processingDate = StartDate;

            trial.TotalStories = storiesForThisTrial;
            trial.AddResult(processingDate, storiesForThisTrial);

            while (remainingStoriesForThisTrial > 0)
            {
                processingDate = processingDate.AddDays(7);
                int storiesThisPeriod = Rnd.Next(lowStoriesPerWeekGuess, highStoriesPerWeekGuess + 1);
                remainingStoriesForThisTrial = remainingStoriesForThisTrial - storiesThisPeriod;
                if (remainingStoriesForThisTrial < 0) remainingStoriesForThisTrial = 0;
                trial.AddResult(processingDate, remainingStoriesForThisTrial);
            }

            return trial;

        }
    }
}
