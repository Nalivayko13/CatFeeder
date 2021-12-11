using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Feeder
    {
        public Feeder(string quickid, string quickname)
        {
            Feeder_id = quickid;
            Name = quickname;
            Timetable_id = null;
            User_id = null;
        }

        public Feeder()
        {
        }

        public string User_id;
        public string Feeder_id;
        public string Timetable_id;
        public string Name;
    }
}
