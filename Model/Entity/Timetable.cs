using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        public Timetable() { }

        public Timetable(string _UserId, string _name, string _TimetableId)
		{
            UserId = _UserId;
            name = _name;
            TimetableId = _TimetableId;
		}
        public List<Time> TimeOfFeed { get; set; }
        public string UserId { get; set; }
        public string name { get; set; }
        public string TimetableId { get; set; }

    }
}
