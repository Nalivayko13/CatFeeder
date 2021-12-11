using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class edit_feederPresenter
    {
        private readonly IKernel _kernel;
        private Iedit_feeder _view;
        private IRepository<Feeder> _feederrepository;
        private IRepository<Timetable> _timetablerepository;
        private IFeederService _feederservice;


        private string current_user_id;
        private string current_feeder_id;

        public edit_feederPresenter(IKernel kernel, Iedit_feeder view, IRepository<Feeder> feederrepository, IRepository<Timetable> timetablerepository, IFeederService feederservice)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;
            _timetablerepository = timetablerepository;
            _feederservice = feederservice;

            _view.Show_goback += Show_goback;
            _view.Show_update += Show_update;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username, string feeder_id)
        {
            current_user_id = username;
            current_feeder_id = feeder_id;

          //  short update_result = _feederservice.Update_feeder(feeder_name);
         
            _view.Show();
        }


        private void Show_update(string feedername)
        {
            short update_result = _feederservice.Update_feeder(current_feeder_id,feedername);

            _view.update_result_response(update_result);

        }

    }
}
