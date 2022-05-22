using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
             statsComputer.CalculateStatistics(
                new List<float>{(float)1.5, (float)8.9, (float)3.2, (float)4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statsComputer.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            statsComputer.CalculateStatistics(
                new List<___>{});
   
            Assert.IsNaN(statsComputer.average);
            Assert.IsNaN(statsComputer.max);
            Assert.IsNaN(statsComputer.min);
            
        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = {emailAlert, ledAlert};

            const float maxThreshold = 10.2;
            var statsAlerter = new StatsAlerter(maxThreshold, alerters);
            statsAlerter.checkAndAlert(new List<___>{0.2, 11.9, 4.3, 8.5});

            Assert.True(emailAlert.emailSent);
            Assert.True(ledAlert.ledGlows);
        }
    }
}
