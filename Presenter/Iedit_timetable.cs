using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_timetable : Iview
    {
        public event Action Show_goback;
        public event Action<string> Remove_timestamp;
        //event Action<string> Show_time_update;
        void update_result_response(short update_result);

        void display_timestamp_list(Timetable timetable);
    }
}
