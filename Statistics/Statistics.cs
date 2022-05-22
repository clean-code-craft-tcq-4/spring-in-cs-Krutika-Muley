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
        
    }
}
