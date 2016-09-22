using Microsoft.EntityFrameworkCore;

namespace hwnn.Models
{
    public class ContosoContext : DbContext
    {
        public ContosoContext(DbContextOptions<ContosoContext> options)
            : base(options)
        {
        }

        // В этом методе мы конфигурируем контекст
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(p => p.Id).IsRequired().HasColumnName("Id");
            });
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Contact> Contacts { get; set; }

    } 
}