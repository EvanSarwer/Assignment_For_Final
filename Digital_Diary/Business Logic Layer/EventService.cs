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
        public List<Event> GetEventListForSearch(string eventTitle)
        {
            return eventDataAccess.GetEventsForSearch(eventTitle);
        }



    }
}
