using Digital_Diary.Data_Access_Layer;
using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Business_Logic_Layer
{
    class UserService
    {
        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }
        public List<User> GetListOfUsers()
        {
            return this.userDataAccess.GetAllUsers();
        }
        public int AddNewUser(string userName)
        {
            User user = new User()
            {
                Username = userName
            };
            return this.userDataAccess.InsertUser(user);
        }
        public int UpdateUser(int id,string userName)
        {
            User user = new User()
            {
                Id = id,
                Username = userName
            };
            return this.userDataAccess.UpdateUser(user);
        }
        public int DeleteUser(string id)
        {
            return this.userDataAccess.DeleteUser(Convert.ToInt32(id));
        }
        public List<string> GetUserNameList()
        {
            return this.userDataAccess.GetUserNames();
        }
        public List<Event> GetEventListByUser(string userName)
        {
            return this.userDataAccess.GetEventByUser(userName);
        }
    }
}
