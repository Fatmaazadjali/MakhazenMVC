using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakhazenMVC.DAL.Model
{
    public class Payment
    {
        //public enum PaymentStatus
        //{
        //    Pending,
        //    Processed,
        //    Failed
        //}


        public int PaymentID { get; set; }
            public int BookingID { get; set; }
            public decimal Amount { get; set; }
            public DateTime PaymentDate { get; set; }
            public string PaymentStatus { get; set; } // Enum
           
    }
}
