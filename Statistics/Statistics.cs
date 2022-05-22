using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
         public void CalculateStatistics(List<float> numbers)
        {
            var numbersArray = numbers.ToArray();
            int length = numbersArray.Length;
           bool isEmpty = (length == 0);
            if (isEmpty)
            {
                average = Double.NaN;
                min = Double.NaN;
                max = Double.NaN;
            }
            else
            {
                var sum = numbersArray[0];
                 min = numbersArray[0];
                 max = numbersArray[0];
                for (int i = 1; i < length; i++)
                {
                    sum += numbersArray[i];
                    min = Math.Min(min, numbersArray[i]);
                    max = Math.Max(max, numbersArray[i]);
                }
                average = sum / numbersArray.Length;
            }
        }
        public double average;
        public double min;
        public double max;
    }
    
   public class StatsAlerter
    {

        StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            threshold = maxThreshold;
            alerters1 = alerters;
        }
            public void checkAndAlert(List<float> numbers)
       {
            var numbersArray = numbers.ToArray();
            max = numbersArray[0];
            for (int i = 1; i < numbersArray.Length; i++)
            {
                max = Math.Max(max, numbersArray[i]);
                if (max > threshold)
                {
                    alerters1[0].Alerter();
                    alerters1[1].Alerter();
                    break;
                }
         }

        }


        float threshold;
        float max;
        IAlerter[] alerters1;


    }

    public interface IAlerter
    {
        void Alerter();
    }

    public class EmailAlert : IAlerter
    {
        public bool emailSent { get; set; }
        public void Alerter()
        {
            emailSent = true;
        }
    }

    public class LEDAlert : IAlerter
    {
        public bool ledGlows { get; set; }
        public void Alerter()
        {
            ledGlows = true;
        }

    }
}
