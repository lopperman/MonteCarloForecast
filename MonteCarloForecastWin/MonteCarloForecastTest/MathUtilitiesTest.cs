using MonteCarloForecast;
using NUnit.Framework;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class MathUtilitiesTest
    {
        [Test]
        public void PercentileRank()
        {
            double[] values = new double[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
            int position = 6;
            double percentileRank = MathUtilities.PercentileRank(values, position);

            Assert.AreEqual(60, percentileRank);

            values = new double[] { 5, 1, 1, 1, 1, 1, 1, 1, 8, 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 1, 5, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 1, 1, 1, 1 };

            Assert.AreEqual(98d, MathUtilities.PercentileRank(values, 5));
            Assert.AreEqual(88d, MathUtilities.PercentileRank(values, 1));
            Assert.AreEqual(88d, MathUtilities.PercentileRank(values, 2));
            Assert.AreEqual(88d, MathUtilities.PercentileRank(values, 3));
            Assert.AreEqual(88d, MathUtilities.PercentileRank(values, 4));
            Assert.AreEqual(100d, MathUtilities.PercentileRank(values, 8));
        }

        [Test]
        public void Percentile()
        {
            //need some assertions here ... grabbed this off of google.

            double[] values = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double perc = 1.0d;

            double percentile = MathUtilities.Percentile(values, perc);

            
        }
    }
}
