using MonteCarloForecast;
using NUnit.Framework;
using System;

namespace MonteCarloForecastTest
{
    [TestFixture]
    public class ForecastResultTest
    {
        [Test]
        public void ForecastResultConstructorAndProperties()
        {
            decimal likelihood = 0.89m;
            int weeks = 4;
            DateTime dt = DateTime.Now;
            ForecastResult result = new ForecastResult(likelihood, weeks, dt);

            Assert.AreEqual(likelihood, result.Likelihood);
            Assert.AreEqual(weeks, result.Weeks);
            Assert.AreEqual(dt, result.Date);

        }
        
    }
}
