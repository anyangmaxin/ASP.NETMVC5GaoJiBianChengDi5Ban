using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore_07.Models
{
    public class Order 
    {
        public int OrderId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required]
        [StringLength(170, MinimumLength = 3)]
        [Display(Name = "First Name",Order = 15000)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your {0} is required.")]
        [Display(Name = "Last Name",Order = 15001)]
        [StringLength(170, ErrorMessage = "{0} is too long.")]
        public string LastName { get; set; }
        [Range(35, 44)]
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email doesn't look like a valid email address.")]
        public string Email { get; set; }
        [Compare("Email")]
        public string EmailConfirm { get; set; }

        [ReadOnly(true)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:c}")]
        public decimal Total { get; set; }
        // public List<OrderDetail> OrderDetails { get; set; } 
 
    }
}