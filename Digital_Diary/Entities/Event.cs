using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Entities
{
    class Event
    {
        public int EventID { get; set; }
        public string EventTitle { get; set; }
        public string Date { get; set; }
        public  string EventDescription { get; set; }
        public string UpdatedDate { get; set; }
        public string Importance { get; set; }
        public int Id { get; set; }
        
    }
}
