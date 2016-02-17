using System.ComponentModel.DataAnnotations;

namespace _15Demo.Areas.FluentMetadata.Models
{
    public class Contact
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
    }
}