using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    

    public interface Ilogin : Iview
    {

        event Action<string, string> Show_login;
        event Action Show_register_screen;

    }
}
