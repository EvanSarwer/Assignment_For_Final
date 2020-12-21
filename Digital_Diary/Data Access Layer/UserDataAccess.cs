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

    }
}
