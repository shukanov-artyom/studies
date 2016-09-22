using System.ComponentModel.DataAnnotations;

namespace hwnn.Models
{
    public class Contact
    {
        [MaxLength(50)]
        [MinLength(2)]
        public string FirstName
        {
            get;
            set;
        }

        [MaxLength(50)]
        [MinLength(2)]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        public int Id
        {
            get;
            set;
        }
    }
}
