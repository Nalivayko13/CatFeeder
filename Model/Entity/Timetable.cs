using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        public Timetable() { }

        public Timetable(string _feederId, string _name, string _TimetableId,string _time)
		{
            FeederId = _feederId;
            name = _name;
            TimetableId = _TimetableId;
            time = _time;
		}
        public List<Time> TimeOfFeed { get; set; }
        public string FeederId { get; set; }
        public string name { get; set; }
        public string TimetableId { get; set; }
        public string time { get; set; }

    }
}
