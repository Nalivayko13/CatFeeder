using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ihome_user : Iview
    {
        public event Action Show_add_feeder;
        public event Action Show_manage_timetables;
        public event Action Show_logout;
        public event Action<string> Show_feeder_settings;
        public event Action<string> Show_feeder_info;
        void display_feeder_list(List<Feeder> feederlist);
    }
}
