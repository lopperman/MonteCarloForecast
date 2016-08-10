using System;
using System.Linq;

namespace MonteCarloForecast
{
    public static class MathUtilities
    {
        /// <summary>
        /// What percentage of [values] is less than or equal to [i]
        /// </summary>
        /// <param name="values"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static double PercentileRank(double[] values, double i)
        {
            Array.Sort(values);
            double[] results = values.Where(x => x <= i).ToArray();

            double selected = Convert.ToDouble(results.Length);
            double total = Convert.ToDouble(values.Length);

            return Math.Round(((selected / total) * 100), 0, MidpointRounding.AwayFromZero);
        }



        public static double Percentile(double[] sequence, double percentile)
        {
            Array.Sort(sequence);
            int N = sequence.Length;

            double n = (N - 1) * percentile + 1;
            // Another method: double n = (N + 1) * excelPercentile;
            if (n == 1d) return sequence[0];
            else if (n == N) return sequence[N - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return sequence[k - 1] + d * (sequence[k] - sequence[k - 1]);
            }
        }

        public static double GetWeightedMovingAverage(double[] samples, int position)
        {
            double samplesSum = samples.Sum();

            return (double)(position+1) / samplesSum;
        }

        public static double[,] BuildWeightPercentMatrix(double[] samples)
        {
            double[,] ret = new double[samples.Length, 2];

            double[] samplePositions = new double[samples.Length];
            for (int i = 0; i < samples.Length; i ++)
            {
                samplePositions[i] = i + 1;
            }

            double samplesSum = samplePositions.Sum();

            double cumulativeTotal = 0;

            for (int i = samples.GetLowerBound(0); i <= samples.GetUpperBound(0); i ++)
            {
                ret[i, 0] = samples[i];
                cumulativeTotal += (i + 1) / samplesSum;
                ret[i, 1] = cumulativeTotal;
            }

            return ret;
        }
    }
}
