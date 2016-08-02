using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
