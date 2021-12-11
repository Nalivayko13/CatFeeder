using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ifeeder_id_list : Iview
    {
        public event Action Show_goback;
        public event Action<string> Add_feeder;
        public event Action<string> Remove_feeder;

        void display_GLOBAL_feeder_list(List<Feeder> gLOBAL_feederlist);
    }
}
