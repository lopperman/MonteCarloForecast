using MonteCarloForecast;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
