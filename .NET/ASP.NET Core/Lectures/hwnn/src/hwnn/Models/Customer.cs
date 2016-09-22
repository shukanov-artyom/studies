using System.ComponentModel.DataAnnotations;

namespace hwnn.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(2)]
        public string CustomerName { get; set; }
    }
}
