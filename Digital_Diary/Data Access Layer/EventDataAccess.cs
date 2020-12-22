using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Data_Access_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;
        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Event> GetAllEvents()
        {
            string sql = "SELECT * FROM Events";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event eventz = new Event();
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
        public int InsertEvent(Event eventz)
        {
            string sql = "INSERT INTO Events(EventTitle,Date,EventDescription,Importance,Id) VALUES('"+eventz.EventTitle+"','"+eventz.Date+"','"+eventz.EventDescription+"','"+eventz.Importance+"',"+eventz.Id+")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int GetUserId(string userName)
        {
            string sql = "SELECT * FROM Users WHERE Username='"+userName+"'" ;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return (int)reader["Id"];
        }
        public List<Event> GetEventsForSearch(string eventTitle)
        {
            string sql = "SELECT * FROM Events WHERE EventTitle LIKE'%"+eventTitle+"%'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event eventz = new Event();
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
