using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakhazenMVC.DAL.Model
{
    public class Review
    {

        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int StoreID { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
