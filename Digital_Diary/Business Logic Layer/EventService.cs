using Digital_Diary.Data_Access_Layer;
using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Business_Logic_Layer
{
    class EventService
    {
        EventDataAccess eventDataAccess;
        public EventService()
        {
            eventDataAccess = new EventDataAccess();
        }
        public List<Event> GetEventList()
        {
            return eventDataAccess.GetAllEvents();
        }
        public int AddNewEvent(string eventTitle,string date,string eventDescription,string importance,string userName)
        {
            int userId = eventDataAccess.GetUserId(userName);
            Event eventz = new Event()
            {
                EventTitle=eventTitle,
                Date=date,
                EventDescription=eventDescription,
                Importance=importance,
                Id=userId
            };
            eventDataAccess = new EventDataAccess();
            return eventDataAccess.InsertEvent(eventz);
        }
        public int UpdateEvent(int eventId,string eventTitle,string updatedDate,string eventDescription)
        {
            Event eventz = new Event()
            {
                EventID=eventId,
                EventTitle = eventTitle,
                UpdatedDate = updatedDate,
                EventDescription = eventDescription
            };
            return eventDataAccess.UpdateEvent(eventz);
        }
        public int DeleteEvent(string id)
        {
            return this.eventDataAccess.DeleteEvent(Convert.ToInt32(id));
        }
        public List<Event> GetEventListForSearch(string userName,string eventTitle)
        {
            int userId = eventDataAccess.GetUserId(userName);
            Event eventz = new Event()
            {
                EventTitle = eventTitle,
                Id = userId
            };
            eventDataAccess = new EventDataAccess();
            return eventDataAccess.GetEventsForSearch(userId,eventTitle);
        }
        public List<Event> GetEventListSearchByImpotance(string userName, string importance)
        {
            int userId = eventDataAccess.GetUserId(userName);
            Event eventz = new Event()
            {
                Importance = importance,
                Id = userId
            };
            eventDataAccess = new EventDataAccess();
            return eventDataAccess.GetEventsForSearchByImportance(userId, importance);
        }



    }
}
