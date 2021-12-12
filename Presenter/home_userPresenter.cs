using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;


namespace Presenter
{
    public class home_userPresenter
    {
        private readonly IKernel _kernel;
        private Ihome_user _view;
        private IRepository<Feeder> _feederrepository;
        public List<Feeder> feederlist;

        private string current_user_id;
        private string current_time;

        public home_userPresenter(IKernel kernel, Ihome_user view, IRepository<Feeder> feederrepository)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;

            _view.Show_add_feeder += Show_add_feeder;
            _view.Show_manage_timetables += Show_manage_timetables;
            _view.Show_logout += Show_logout;
            _view.Show_feeder_info += Show_feeder_info;
            _view.Show_feeder_settings += Show_feeder_settings;
        }

        private void Show_feeder_settings(string feeder_id)
        {
            var presenter = _kernel.Get<edit_feederPresenter>();
            presenter.Run(current_user_id, feeder_id, current_time);
            _view.Close();
        }


        private void Show_feeder_info(string feeder_id)
        {
            throw new NotImplementedException();
        }

        private void Show_manage_timetables()
        {
            var presenter = _kernel.Get<manage_timetablesPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_add_feeder()
        {
            var presenter = _kernel.Get<add_feederPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username)
        {
            current_user_id = username;
            _view.Show();
            feederlist = _feederrepository.GetList(username); //по id ползователя (его логин) получаем список кормушек
            _view.display_feeder_list(feederlist);
        }
    }
}