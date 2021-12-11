using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class addFeederPresenter
    {
        private readonly IKernel _kernel;
        private Iadd_feeder _view;
        private IFeederService _feederservice;

        private string current_user_id;

        public addFeederPresenter(IKernel kernel, Iadd_feeder view, IFeederService feederservice)
        {
            _kernel = kernel;
            _view = view;
            _feederservice = feederservice;

            _view.Show_goback += Show_goback;
            _view.Add_feeder += Add_feeder;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        private void Add_feeder(string id)
        {
            short activation_result = _feederservice.Activate_feeder(current_user_id ,id);
            _view.Activation_result_response(activation_result);
        }

        public void Run(string username)
        {
            current_user_id = username;
            _view.Show();
        }
    }
}
