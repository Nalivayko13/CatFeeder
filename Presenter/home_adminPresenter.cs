using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class home_adminPresenter
    {
        private readonly IKernel _kernel;
        private Ihome_admin _view;

        private string current_admin;

        public home_adminPresenter(IKernel kernel, Ihome_admin view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_logout += Show_logout;
            _view.Show_feeder_id_list += Show_feeder_id_list;
        }

        private void Show_feeder_id_list()
        {
            var presenter = _kernel.Get<feeder_id_listPresenter>();
            presenter.Run(current_admin);
            _view.Close();
        }

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }
        public void Run(string username)
        {
            current_admin = username;
            _view.Show();
        }
    }
}
