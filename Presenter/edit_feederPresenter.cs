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
        private ITimetableService _timetableservice;
       


        private string current_user_id;
        private string current_feeder_id;
        private string current_time;
      


        public edit_feederPresenter(IKernel kernel, Iedit_feeder view, IRepository<Feeder> feederrepository, IRepository<Timetable> timetablerepository, IFeederService feederservice,ITimetableService timetableservice)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;
            _timetablerepository = timetablerepository;
            _feederservice = feederservice;
            _timetableservice = timetableservice;
  

            _view.Show_goback += Show_goback;
            _view.Show_update += Show_update;
            _view.Show_time_update += Show_time_update;

        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username, string feeder_id, string timetable)
        {
            current_user_id = username;
            current_feeder_id = feeder_id;
            current_time = timetable;
           
          //  short update_result = _feederservice.Update_feeder(feeder_name);
         
            _view.Show();
        }


        private void Show_update(string feedername)
        {
            short update_result = _feederservice.Update_feeder(current_feeder_id,feedername);
           
            _view.update_result_response(update_result);

        }

        private void Show_time_update(string timetable)
        {
            short update_result1 = _timetableservice.Update_feeder_time(current_feeder_id, timetable);

            _view.update_result_response1(update_result1);
        }


        }
    }
