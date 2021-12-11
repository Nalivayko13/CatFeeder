using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_timetable : Iview
    {
        public event Action<string> Remove_timestamp;

        void display_timestamp_list(Timetable timetable);
    }
}
