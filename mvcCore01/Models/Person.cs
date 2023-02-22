using System.ComponentModel.DataAnnotations;

namespace mvcCore01.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Adress{ get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
