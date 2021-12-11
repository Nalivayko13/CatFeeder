using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Model.Entity
{
    class DB
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
        public MySqlDataAdapter ad;

        public DB()
        {
            this.conn = new MySqlConnection("server=localhost;user=root;password=280401Polina;database=feeder_db;");
            this.ad = new MySqlDataAdapter();
        }

        public DataTable Find(string t, string c)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + t + " WHERE " + c, conn);
            DataTable table = new DataTable();
            ad.SelectCommand = command;
            ad.Fill(table);
            return table;
        }
        public DataTable Find(string t, string c, string u)
        {
            MySqlCommand command = new MySqlCommand("SELECT " + u + " FROM " + t + " WHERE " + c, conn);
            DataTable table = new DataTable();
            ad.SelectCommand = command;
            ad.Fill(table);
            return table;
        }
        public DataTable GetAll(string t)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + t, conn);
            DataTable table = new DataTable();
            ad.SelectCommand = command;
            ad.Fill(table);
            return table;
        }
        public void Add(string t, string c)//working
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + t + " VALUES " + c, conn);
            command.ExecuteNonQuery();
            
            conn.Close();
        }
        public void Add(string t, string c, string colm_n)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + t + " " + colm_n + " VALUES " + c, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(string t, string c, string cond)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("UPDATE " + t + " SET " + c + " WHERE " + cond, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(string t, string c)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM " + t + " WHERE " + c, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
