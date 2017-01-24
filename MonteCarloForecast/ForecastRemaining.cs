using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloForecast
{
    public class ForecastRemaining
    {
        public string Name { get; set; }
        public string ColumnName { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public int Stories { get; set; }

        public List<ForecastRemainingDetail> Detail = new List<ForecastRemainingDetail>();

        public ForecastRemaining(string name, string columnName, DateTime startDt, DateTime endDt, int stories)
        {
            Name = name;
            ColumnName = columnName;
            StartDt = startDt;
            EndDt = endDt;
            Stories = stories;

            BuildDetail();
        }

        private void BuildDetail()
        {
            int totalWeeks = (int) (EndDt.Subtract(StartDt).TotalDays/7);
            totalWeeks = totalWeeks + 1;

            int idealStories = Stories/totalWeeks;
            int weekWithAdditionalStory = (Stories - (totalWeeks*idealStories));

            DateTime processingDt = StartDt;

            int remainingStories = Stories;
            int counter = 1;

            while (processingDt <= EndDt)
            {
                int storiesCompletedThisPeriod = idealStories;
                int remainingStoriesThisPeriod = remainingStories - idealStories;
                if (counter <= weekWithAdditionalStory)
                {
                    remainingStoriesThisPeriod = remainingStoriesThisPeriod - 1;
                    storiesCompletedThisPeriod = storiesCompletedThisPeriod + 1;
                }

                if (processingDt == EndDt)
                {
                    if (remainingStoriesThisPeriod < 0) remainingStoriesThisPeriod = 0;
                }

                Detail.Add(new ForecastRemainingDetail(processingDt,remainingStoriesThisPeriod));

                remainingStories = remainingStories - storiesCompletedThisPeriod;
                processingDt = processingDt.AddDays(7);
                counter += 1;
            }

        }
    }

    public class ForecastRemainingDetail
    {
        public DateTime CompleteDate { get; set; }
        public int RemainingStories { get; set; }

        public ForecastRemainingDetail(DateTime completedDt, int remainingStories)
        {
            CompleteDate = completedDt;
            RemainingStories = remainingStories;
        }
    }
}
