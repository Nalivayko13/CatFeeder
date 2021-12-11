using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Imanage_timetables : Iview
    {
        public event Action Show_goback;
        public event Action<string> Show_edit_timetable;
        public event Action<string> Remove_timetable;
        public event Action Add_timetable;
        void display_timetable_list(List<Timetable> timetablelist);
    }
}
