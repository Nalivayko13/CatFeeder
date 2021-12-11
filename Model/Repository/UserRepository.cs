using Model.Entity;
using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
/*

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT user_id FROM users WHERE user_type = 1", conn);
            string test = command.ExecuteScalar().ToString();
            Console.WriteLine(test);
            Console.ReadLine();
            conn.Close();
            MessageBox.Show(test, "Notification", MessageBoxButtons.OK);
*/

namespace Model.Repository
{
    public class UserRepository : IRepository<User>
    {
        private DB DataContext = new DB();
       // private User user;

        public User Get(string username)
        {
            DataTable table = new DataTable();
            string com = "user_id= '" + username + "'";
            table = DataContext.Find("users", com);
            User user = new User();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    user.username = cells[0].ToString();
                    user.account_type =Convert.ToInt16(cells[1]);
                    user.password_hash = cells[2].ToString();
                    user.password_salt = cells[3].ToString();
                }
            }
            else return null;
            /*user.username = username;
            if (username == "admin")
            {
                user.password_hash = "j32jf22";
                user.password_salt = "admin"; //тут должно быть хэширование
                user.account_type = 2;
            }
            else if (username == "test")
            {
                user.password_hash = "jfs8fds3";
                user.password_salt = "test"; 
                user.account_type = 1;
            }
            else
            {
                user.password_hash = "0";
            }*/
            return user;
        }

        public void Remove(User obj)
        {
            string username = obj.username;
            string com = "user_id = '" + username + "'";
            DataContext.Delete("users", com);
        }
        public int Add(User obj)
        {
            string username = obj.username;
            short account_type = obj.account_type;
            string password_hash = obj.password_hash;
            string password_salt = obj.password_salt;
            // string com = "('29', 2, '123', '3');"; 
            string com = "('" + username + "','" + account_type + "','" + password_hash +"','" + password_salt + "');";
            DataContext.Add("users", com);
            return 0;
        }
        public void Update(User obj, string cond)
        {
            string username = obj.username;
            short account_type = obj.account_type;
            string password_hash = obj.password_hash;
            string password_salt = obj.password_salt;
            string com = "user_id = '" + username + "', user_type = '" + account_type + "', user_password_hash = '" 
                + password_hash + "', user_password_salt = '" + password_salt + "'";
            DataContext.Update("users", com, cond);
        }
        public List<User> GetAll()
        {
            DataTable table = new DataTable();
            table = DataContext.GetAll("users");
            List<User> userList = new List<User>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    User user = new User();
                    var cells = row.ItemArray;
                    user.username = cells[0].ToString();
                    user.account_type = (short)cells[1];
                    user.password_hash = cells[2].ToString();
                    user.password_salt = cells[3].ToString();
                    userList.Add(user);
                }
            }
            else return null;
            return userList;
        }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList(string id)
        {
            throw new NotImplementedException();
        }
    }
}
