using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class manage_timetablesPresenter
    {
        private readonly IKernel _kernel;
        private Imanage_timetables _view;
        private IRepository<Timetable> _timetablerepository;
        private ITimetableService _timetableservice;

        private List<Timetable> timetablelist;

        private string current_user_id;

        public manage_timetablesPresenter(IKernel kernel, Imanage_timetables view, IRepository<Timetable> timetablerepository, ITimetableService timetableservice)
        {
            _kernel = kernel;
            _view = view;
            _timetablerepository = timetablerepository;
            _timetableservice = timetableservice;

            _view.Show_goback += Show_goback;
            _view.Show_edit_timetable += Show_edit_timetable;
            _view.Remove_timetable += Remove_timetable;
            _view.Add_timetable += Add_timetable;
        }

        private void Add_timetable()
        {
            _timetableservice.Add_Timetable(current_user_id);
        }

        private void Remove_timetable(string timetable_id)
        {
            throw new NotImplementedException();
        }

        private void Show_edit_timetable(string timetable_id)
        {
            var presenter = _kernel.Get<edit_timetablePresenter>();
            presenter.Run(timetable_id);
            _view.Close();
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username)
        {
            current_user_id = username;
            _view.Show();
            timetablelist = _timetablerepository.GetList(username);
            _view.display_timetable_list(timetablelist);
        }
    }
}
