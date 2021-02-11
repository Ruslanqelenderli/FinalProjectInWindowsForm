using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RStore.Models
{
    public class User
    {
        public User()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please add Name")]
        [MinLength(3,ErrorMessage = "The name must be at least 4 characters long.")]
        [MaxLength(10,ErrorMessage = "The name must be no more than 10 characters long.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please add surname")]
        [MinLength(5, ErrorMessage = "The surname must be at least 4 characters long.")]
        [MaxLength(13, ErrorMessage = "The surname must be no more than 13 characters long.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please add Email")]
        [EmailAddress(ErrorMessage ="Please add correct email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please add password")]
        [MinLength(5, ErrorMessage = "The password must be at least 4 characters long.")]
        [MaxLength(13, ErrorMessage = "The password must be no more than 13 characters long.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please add phone number")]
        [MinLength(5, ErrorMessage = "The phone number must be at least 4 characters long.")]
        [MaxLength(13, ErrorMessage = "The phone number must be no more than 13 characters long.")]
        public string PhoneNumber { get; set; }
        public string Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
