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
    public class TrialTest
    {
        Trial trial = null;

        [OneTimeSetUp]
        public void setup()
        {
            trial = new Trial();
        }

        [OneTimeTearDown]
        public void teardown()
        {
            trial = null;
        }



    }
}
