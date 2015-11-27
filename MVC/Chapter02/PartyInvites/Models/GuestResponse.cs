using System;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please specify name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please specify valid email address.")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you will attend.")]
        public bool? WillAttend { get; set; }
        
    }
}