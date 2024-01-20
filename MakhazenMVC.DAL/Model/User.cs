using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakhazenMVC.DAL.Model
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Username must be 50 characters or less"), MinLength(4)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone no. is required")]
        public long PhoneNumber { get; set; }

        public string UserType { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; }

        public object Store { get; set; } //I Add to Solve the error in genericrepository for store
    }
}
