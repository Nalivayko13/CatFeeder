using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class edit_timetablePresenter
    {
        private readonly IKernel _kernel;
        private Iedit_timetable _view;
        private IRepository<Timetable> _timetablerepository;

        private string current_timetable_id;

        public edit_timetablePresenter(IKernel kernel, Iedit_timetable view, IRepository<Timetable> timetablerepository)
        {
            _kernel = kernel;
            _view = view;
            _timetablerepository = timetablerepository;

            _view.Remove_timestamp += Remove_timestamp;
        }

        private void Remove_timestamp(string obj)
        {
            throw new NotImplementedException();
        }

        public void Run(string timetable_id)
        {
            current_timetable_id = timetable_id;
            _view.Show();
            Timetable timetable = _timetablerepository.Get(timetable_id);
            _view.display_timestamp_list(timetable);
        }
    }
}
