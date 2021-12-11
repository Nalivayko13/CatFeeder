using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Time : ITime
    {
        public string TimeHMS { get; set; }
        public int Id;

        public Time()
        {
            TimeHMS = DateTime.Now.ToString("HH:mm");
        }
        public Time(string t)
        {
        }
        public string Get_TimeHMS()
        {
            return this.TimeHMS;
        }

        public bool CompareTimeHMS(Time t2)
        {
            if (this.TimeHMS == t2.TimeHMS) return true;
            return false;
        }
    }
}
