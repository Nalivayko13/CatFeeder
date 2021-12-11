using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        public List<Time> TimeOfFeed { get; set; }
        public string UserId { get; set; }
        public string name { get; set; }
        public string TimetableId { get; set; }

    }
}
