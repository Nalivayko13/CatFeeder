using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iadd_feeder : Iview
    {
        public event Action Show_goback;
        public event Action<string> Add_feeder;

        void Activation_result_response(short activation_result);

    }
}
