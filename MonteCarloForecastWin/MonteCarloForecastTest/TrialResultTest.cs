using MonteCarloForecast;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class TrialResultTest
    {
        [Test]
        public void NewUpTrialResult()
        {
            TrialResult tr = new TrialResult();
            Assert.IsNotNull(tr);
        }

        [Test]
        public void SetTrialResultStories()
        {
            TrialResult trs = new TrialResult();
            trs.TotalStories = 10;
            Assert.AreEqual(10, trs.TotalStories);
        }

        [Test]
        public void AddWeekEndingDateWithStoriesForWeek()
        {
            int totalStories = 40;

            TrialResult tr = new TrialResult(totalStories);
            DateTime dt = DateTime.Today;
            int storiesForPeriod = 5;
            tr.AddResult(dt, storiesForPeriod);
            SortedDictionary<DateTime, int> dict = tr.Results;
        }

        [Test]
        public void CheckInvalidStoryCounts()
        {
            int totalStories = 40;

            TrialResult tr = new TrialResult(totalStories);
            DateTime dt = DateTime.Today;
            int storiesForPeriod = 41;
            Assert.Throws<ArgumentOutOfRangeException>(() => tr.AddResult(dt, storiesForPeriod));

            totalStories = 10;
            tr = new TrialResult(totalStories);
            int storiesForPeriod1 = 5;
            tr.AddResult(dt, storiesForPeriod1);
            Assert.AreEqual(5, tr.GetResultsTotalStories());

            int storiesForPeriod2 = 3;
            tr.AddResult(dt.AddDays(7), storiesForPeriod2);
            Assert.AreEqual(8, tr.GetResultsTotalStories());

        }
    }
}
