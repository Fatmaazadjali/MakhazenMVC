using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakhazenMVC.DAL.Model
{
    public class Booking
    {

        //public enum Status
        //{
        //    Pending,
        //    Confirmed,
        //    Cancelled
        //}
   
            public int BookingID { get; set; }
            public int UserID { get; set; }
            public int StoreID { get; set; }
            public DateTime BookingDate { get; set; }
            public string Status { get; set; } // Enum
            public int PaymentID { get; set; }
        }
    
}
