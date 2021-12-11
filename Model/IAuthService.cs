using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IAuthService
    {
        short Login(string username, string password);
        short Register(string username, string password, string confirm_password);
    }
}
