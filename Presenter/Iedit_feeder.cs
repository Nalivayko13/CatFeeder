using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_feeder : Iview
    {
        public event Action Show_goback;
        event Action<string> Show_update;
        event Action<string> Show_time_update;


        void update_result_response(short update_result);
        void update_result_response1(short update_result);
    }
}
