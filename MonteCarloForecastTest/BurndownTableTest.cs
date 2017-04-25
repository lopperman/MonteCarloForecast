using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class BurndownTableTest
    {

        private BurndownTable burndownTable = null;

        [SetUp]
        public void setup()
        {
            DateTime releaseStartDate = new DateTime(2017, 1, 1);
            DateTime idealCompleteDate = new DateTime(2017, 6, 15);
            DayOfWeek dayOfWeek = DayOfWeek.Friday;
            int totalStories = 100;
            int totalOpenStories = 60;
            SortedList<DateTime, int> completedStories = new SortedList<DateTime, int>();
            completedStories.Add(new DateTime(2017, 3, 1), 5);
            completedStories.Add(new DateTime(2017, 3, 8), 4);
            completedStories.Add(new DateTime(2017, 3, 12), 7);

            burndownTable = new BurndownTable(releaseStartDate, idealCompleteDate, dayOfWeek, totalStories, totalOpenStories, completedStories);
        }

        [TearDown]
        public void teardown()
        {
            burndownTable = null;
        }


        [Test]
        public void testAddRecord()
        {
            burndownTable.AddRecord(DateTime.Now.Date, 1, 2, 50, 55, 60, 65, 70, 75, 80, 85, 95, 100);
            Assert.AreEqual(1,burndownTable.Rows.Count());
        }

    }

    public class BurndownTable
    {
        private List<BurndownRow> _rows = new List<BurndownRow>();

        public DateTime ReleaseStartDt { get; set; }
        public DateTime IdealCompleteDt { get; set; }
        public DayOfWeek WeekEndingDay { get; set; }
        public int TotalStories { get; set; }
        public int TotalOpenStories { get; set; }

        private SortedList<DateTime,int> _closedStories = new SortedList<DateTime, int>();

        public SortedList<DateTime, int> ClosedStories
        {
            get { return _closedStories; }
        }

        public BurndownTable(DateTime releaseStartDt, DateTime idealCompleteDate, DayOfWeek weekEndingDay, int totalStories, int totalOpenStories, SortedList<DateTime,int> closedStories)
        {
            ReleaseStartDt = releaseStartDt;
            IdealCompleteDt = idealCompleteDate;
            WeekEndingDay = weekEndingDay;
            TotalStories = totalStories;
            TotalOpenStories = totalStories;
            _closedStories = closedStories;
        }

        public void AddRecord(DateTime weekEnding, int ideal, int actual, int perc1, int perc2, int perc3, int perc4,
            int perc5, int perc6, int perc7, int perc8, int perc9, int perc10)
        {
            _rows.Add(new BurndownRow(weekEnding, ideal, actual, perc1, perc2, perc3, perc4, perc5, perc6, perc7, perc8, perc9, perc10));
        }

        public List<BurndownRow> Rows
        {
            get { return _rows; }

        }
    }

    public class BurndownRow
    {
        public BurndownRow(DateTime weekEnding, int ideal, int actual, int perc1, int perc2, int perc3, int perc4, int perc5, int perc6, int perc7, int perc8, int perc9, int perc10)
        {
            WeekEnding = weekEnding;
            Ideal = ideal;
            Actual = actual;
            Perc1 = perc1;
            Perc2 = perc2;
            Perc3 = perc3;
            Perc4 = perc4;
            Perc5 = perc5;
            Perc6 = perc6;
            Perc7 = perc7;
            Perc8 = perc8;
            Perc9 = perc9;
            Perc10 = perc10;
        }

        public DateTime WeekEnding { get; set; }
        public int Ideal { get; set; }
        public int Actual { get; set; }
        public int Perc1 { get; set; }
        public int Perc2 { get; set; }
        public int Perc3 { get; set; }
        public int Perc4 { get; set; }
        public int Perc5 { get; set; }
        public int Perc6 { get; set; }
        public int Perc7 { get; set; }
        public int Perc8 { get; set; }
        public int Perc9 { get; set; }
        public int Perc10 { get; set; }

    }
}
