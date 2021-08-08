using System;
using System.Collections.Generic;
using System.Text;

namespace Target_Heart_Rate_Calculator
{
    class HeartRates
    {        
        public string Name { get; set; }
        public int Birthyear { get; set; }

        public int MaxHeartRate()
        {            
            int maxHeartRate = 220 - GetAge();
            return maxHeartRate;
        }

        public int TargetHeartRate()
        {
            int targetHeartRate = Convert.ToInt32(MaxHeartRate() * 0.8);
            return targetHeartRate;
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - Birthyear;
            return age;
        }
    }
}
