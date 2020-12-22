using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Data_Access_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public bool LoginValidation(string userName,string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + userName + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if(reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<User> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<User> users = new List<User>();
            while(reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Username = reader["UserName"].ToString();
                users.Add(user);
            }
            return users;
        }
        public User GetUser(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            User user = new User();
            user.Id = (int)reader["Id"];
            user.Username = reader["Username"].ToString();
            return user;
        }
        public int InsertUser(User user)
        {
            string sql = "INSERT INTO Users(Username) VALUES('"+user.Username+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateUser(User user)
        {
            string sql = "UPDATE Users SET Username='"+user.Username+"' WHERE Id="+user.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteUser(int id)
        {
            string sql = "DELETE FROM Users WHERE Id="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public List<string> GetUserNames()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> users = new List<string>();
            while (reader.Read())
            {
                users.Add(reader["UserName"].ToString());
            }
            return users;
        }
        public List<Event> GetEventByUser(string userName)
        {
            string userIdSearch = "SELECT * FROM Users WHERE Username='"+userName+"'";
            SqlDataReader reader = this.dataAccess.GetData(userIdSearch);
            reader.Read();
            int userId = (int)reader["Id"];
            string sql = "SELECT * FROM Events WHERE Id=" +userId;
            this.dataAccess = new DataAccess();
            reader = this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while(reader.Read())
            {
                Event eventz =new Event();
                eventz.EventID = (int)reader["EventID"];
                eventz.EventTitle = reader["EventTitle"].ToString();
                eventz.Date = reader["Date"].ToString();
                eventz.EventDescription = reader["EventDescription"].ToString();
                eventz.UpdatedDate = reader["UpdatedDate"].ToString();
                eventz.Importance = reader["Importance"].ToString();
                eventz.Id = (int)reader["Id"];
                events.Add(eventz);
            }
            return events;
        }

    }
}
