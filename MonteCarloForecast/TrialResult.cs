using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloForecast
{
    public class TrialResult
    {
        public int TotalStories { get; set; }
        public SortedDictionary<DateTime, int> Results = new SortedDictionary<DateTime, int>();

        public TrialResult()
        {
            Results = new SortedDictionary<DateTime, int>();
        }

        public TrialResult(int totalStories)
        {
            TotalStories = totalStories;
            Results = new SortedDictionary<DateTime, int>();
        }

        public void AddResult(DateTime weekEnding, int stories)
        {
            if (stories > TotalStories)
            {
                throw new ArgumentOutOfRangeException("The value of [stories] cannot be greater than [totalStories]");
            }

            if (!Results.ContainsKey(weekEnding.Date)) Results.Add(weekEnding.Date, stories);
        }

        public int GetResultsTotalStories()
        {
            return Results.Sum(x => x.Value);
        }
    }
}
