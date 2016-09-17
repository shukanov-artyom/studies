using Microsoft.EntityFrameworkCore;

namespace hwnn.Models
{
    public class ContosoContext : DbContext
    {
        public ContosoContext(DbContextOptions<ContosoContext> options)
            : base(options)
        {
            
        }     

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    } 
}