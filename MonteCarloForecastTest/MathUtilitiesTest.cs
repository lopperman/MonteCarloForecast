using MonteCarloForecast;
using NUnit.Framework;
using System;

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

        [Test]
        public void testBuildWeightPercentMatrix()
        {
            double[] samples = new double[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            double[,] test = MathUtilities.BuildWeightPercentMatrix(samples);

            Assert.AreEqual(0.018181818181818181, test[0, 1]);
            Assert.AreEqual(0.054545454545454543, test[1, 1]);
            Assert.AreEqual(0.10909090909090909, test[2, 1]);
            Assert.AreEqual(0.18181818181818182, test[3, 1]);
            Assert.AreEqual(0.27272727272727271, test[4, 1]);
            Assert.AreEqual(0.38181818181818178, test[5, 1]);
            Assert.AreEqual(0.509090909090909, test[6, 1]);
            Assert.AreEqual(0.65454545454545454, test[7, 1]);
            Assert.AreEqual(0.81818181818181812, test[8, 1]);
            Assert.AreEqual(1m, test[9, 1]);
        }

        [Test]
        public void testWeightedMovingAverage()
        {
            double[] samples = new double[] { 10,9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int position = 9;
            double result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.1818m, result);

            position = 8;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.1636m, result);

            position = 7;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.1455m, result);

            position = 6;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.1273m, result);

            position = 5;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.1091m, result);

            position = 4;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.0909m, result);

            position = 3;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.0727m, result);

            position = 2;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.0545m, result);

            position = 1;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.0364m, result);

            position = 0;
            result = Math.Round(MathUtilities.GetWeightedMovingAverage(samples, position), 4);
            Assert.AreEqual(0.0182m, result);

        }
    }
}
