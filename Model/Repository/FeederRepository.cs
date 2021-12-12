using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace Model.Repository
{
    public class FeederRepository : IRepository<Feeder>
    {
        private DB DataContext = new DB();
        public int Add(Feeder obj)
        {
            string User_id = obj.User_id;
            string Feeder_id = obj.Feeder_id;
            string Timetable_id = obj.Timetable_id;
            string Name = obj.Name;
            string com = "('" + Feeder_id + "', '" + User_id + "', '" + Timetable_id + "', '" + Name + "')";
           // string com = "('" + Feeder_id + "', '" + User_id + "', '" + Timetable_id + "')";
            DataContext.Add("feeders", com);
            return 0;
        }
        public void Remove(Feeder obj)
        {
            string Feeder_id = obj.Feeder_id;
            string com = "feeder_id = '" + Feeder_id + "'";
            DataContext.Delete("feeders", com);
        }
        public void Update(Feeder obj, string cond)
        {

            string User_id = obj.User_id;
            string Feeder_id = obj.Feeder_id;
            string Timetable_id = obj.Timetable_id;
            string Name = obj.Name;
            string com =  "feeder_name = '" + Name + "'";

            DataContext.Update("feeders", com, cond);
        }
        public void Save()
        {
        }
        public Feeder Get(string Feeder_id)
        {
            DataTable table = new DataTable();
            string com = "feeder_id= '" + Feeder_id + "'";
            table = DataContext.Find("feeders", com);
            Feeder feeder = new Feeder();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    feeder.User_id = cells[0].ToString();
                    feeder.Feeder_id = cells[1].ToString();
                    feeder.Timetable_id = cells[2].ToString();
                    feeder.Name = cells[3].ToString();
                }
            }
            else return null;
            return feeder;
        }
        public List<Feeder> GetAll()
        {
            DataTable table = new DataTable();
            table = DataContext.GetAll("feeders");
            List<Feeder> feederList = new List<Feeder>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Feeder feeder = new Feeder();
                    var cells = row.ItemArray;
                    feeder.User_id = cells[1].ToString();
                    feeder.Feeder_id = cells[0].ToString();
                    feeder.Timetable_id = cells[2].ToString();
                    feeder.Name = cells[3].ToString();
                    feederList.Add(feeder);
                }
            }
            else return null;
            return feederList;
        }
        public List<Feeder> GetList(string user_id)
        {
            DataTable table = new DataTable();
            string com = "user_id= '" + user_id + "'";
            table = DataContext.Find("feeders", com);
            List<Feeder> feederList = new List<Feeder>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Feeder feeder = new Feeder();
                    var cells = row.ItemArray;
                    feeder.User_id = cells[1].ToString();
                    feeder.Feeder_id = cells[0].ToString();
                    feeder.Timetable_id = cells[2].ToString();
                    feeder.Name = cells[3].ToString();
                    feederList.Add(feeder);
                }
            }
            else return null;
            return feederList;
        }

        public List<Feeder> GetAll(string id)
        {
            throw new NotImplementedException();
        }
    }
}