using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakhazenMVC.DAL.Model
{
    public class Provider
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "First Name must be 30 characters or less"), MinLength(4)]

        public string CompanyName { get; set; }

        public string contactperson { get; set; }

        [DataType(DataType.EmailAddress)]

        public string contactEmail { get; set; }
        [Phone]
        [Required(ErrorMessage = "Phone no. is required")]
        public string contactphone { get; set; }

        public bool premiumAccount { get; set; }

    }
}
