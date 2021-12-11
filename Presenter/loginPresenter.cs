using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class loginPresenter
    {
        private readonly IKernel _kernel;
        private Ilogin _view;
        private IAuthService _authservice;


        public loginPresenter(IKernel kernel, Ilogin view, IAuthService authservice)
        {
            _kernel = kernel;
            _view = view;
            _authservice = authservice;

            _view.Show_login += Show_login;
            _view.Show_register_screen += Show_register_screen;
        }

        private void Show_register_screen()
        {
            var presenter = _kernel.Get<reg_screenPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_login(string username, string password)
        {
            short user_type = _authservice.Login(username, password); //если выдаёт не 1 и не 2 ( 0 ), то данные для входа неверны
																	  //var presenter = _kernel.Get<home_userPresenter>();
																	  //presenter.Run(username);
																	  //_view.Close();
			if (user_type == 1)
			{
				var presenter = _kernel.Get<home_userPresenter>();
				presenter.Run(username);
				_view.Close();
			}
			else if (user_type == 2)
			{
				var presenter = _kernel.Get<home_adminPresenter>();
				presenter.Run(username);
				_view.Close();
			}
			else
				MessageBox.Show("Wrong login or password!", " Try again!", MessageBoxButtons.OK); //вынести в view
		}

		public void Run()
        {
            _view.Show();
        }
    }
}
