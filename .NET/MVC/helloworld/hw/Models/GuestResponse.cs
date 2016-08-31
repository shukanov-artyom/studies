using System;
using System.ComponentModel.DataAnnotations;

namespace hw.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Name must be present!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email must be present!")]
        [RegularExpression(".+\\@.+\\..+")] // does it contain dot and @?
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone must be present!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you will attend!")]
        public bool? WillAttend { get; set; }
    }
}