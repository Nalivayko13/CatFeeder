using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;

namespace Model.Service
{
    public class TimetableService : ITimetableService
    {
        private IRepository<Timetable> _timetablerepository;

        private static Random random = new Random();

        public TimetableService(IRepository<Timetable> timetablerepository)
        {
            _timetablerepository = timetablerepository;
        }

        public void Add_Timetable(string current_user_id)
        {
            //         Timetable timetable;
            //         string timetable_id;

            //while (true)
            //{
            //	timetable_id = RandomString(10);
            //	timetable = _timetablerepository.Get(timetable_id);
            //	if (timetable == null) break;
            //}
            //timetable_id = RandomString(10);
            //         timetable = _timetablerepository.Get(timetable_id);




            //         timetable = new Timetable();
            //         timetable.name = "Расписание uWu";
            //         timetable.TimetableId = timetable_id;
            //         timetable.UserId = current_user_id;
            //         _timetablerepository.Add(timetable);
            Timetable timetable = new Timetable(current_user_id, "timetable name", RandomString(10),"9:00" );
            _timetablerepository.Add(timetable);

        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public short Update_feeder_time(string current_feeder_id, string timetable)
        {

            if (timetable == "")
                return 0;

            Timetable new_timetable = new Timetable(current_feeder_id,"name_time",RandomString(5),timetable);
            //string cond = "feeder_id = '" + current_feeder_id + "';";
            _timetablerepository.Add(new_timetable);
            return 1;


     
        }

    }
}
