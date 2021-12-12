using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface ITimetableService
    {
        void Add_Timetable(string current_user_id);
        short Update_feeder_time(string feeder_id, string timetable);
    }
}
