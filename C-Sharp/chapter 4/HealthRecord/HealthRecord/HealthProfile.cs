using System;
using System.Collections.Generic;
using System.Text;

namespace HealthRecord
{
    class HealthProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int BirthdateDay { get; set; }
        public int BirthdateMonth { get; set; }
        public int BirthdateYear { get; set; }
               
        public HealthProfile()
        {

        }        
        public decimal CalcBMI()
        {
            decimal bmi = this.Weight / ((this.Height * this.Height)/10000);
            return bmi;
        }
        public int HeartrateMax()
        {
            int heartRateMax = 220 - (DateTime.Now.Year - this.BirthdateYear);
            return heartRateMax;
        }
        public int TargetHeartrateMax()
        {
            int targetHeartRateMax = Convert.ToInt32(HeartrateMax() * 0.85);
            return targetHeartRateMax;
        }
        public int TargetHeartrateMin()
        {
            int targetHeartRateMin = Convert.ToInt32(this.HeartrateMax() * 0.5);
            return targetHeartRateMin;
        }
        public int GetAge()
        {
            int getAge = DateTime.Now.Year - this.BirthdateYear;
            return getAge;
        }    
    }
}