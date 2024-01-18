using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MakhazenMVC.DAL.Model
{
    public class Store
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreId { get; set; }
        [Range(0, 500)]
        public int Size { get; set; }

        public string Location { get; set; }

        public string facilities { get; set; }
        [DataType(DataType.Currency)]
        public decimal price { get; set; }

        public bool Availability { get; set; }

        [ForeignKey("departmentEmp")]
        public int CompanyId { get; set; }
        public string Company { get; set; }
    }
}
