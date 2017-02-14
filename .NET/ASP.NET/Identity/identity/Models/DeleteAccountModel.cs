using System;
using System.ComponentModel.DataAnnotations;

namespace identity.Models
{
    public class DeleteAccountModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}