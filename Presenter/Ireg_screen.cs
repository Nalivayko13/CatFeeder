using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ireg_screen : Iview
    {
        event Action Show_login_screen;
        event Action<string, string, string> Show_register;

        void register_result_response(short register_result);
    }
}
