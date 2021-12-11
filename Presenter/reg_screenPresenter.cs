using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class reg_screenPresenter
    {
        private readonly IKernel _kernel;
        private Ireg_screen _view;
        private IAuthService _authservice;

        public reg_screenPresenter(IKernel kernel, Ireg_screen view, IAuthService authservice)
        {
            _kernel = kernel;
            _view = view;
            _authservice = authservice;

            _view.Show_login_screen += Show_login_screen;
            _view.Show_register += Show_register;
        }

        private void Show_login_screen()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_register(string username, string password, string confirm_password)
        {
            short register_result = _authservice.Register(username, password, confirm_password);

            _view.register_result_response(register_result);

            if (register_result == 0)
            {
                var presenter = _kernel.Get<loginPresenter>();
                presenter.Run();
                _view.Close();
            }
            
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
