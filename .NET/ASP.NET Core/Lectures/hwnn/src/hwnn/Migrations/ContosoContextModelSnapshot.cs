using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using hwnn.Models;

namespace hwnn.Migrations
{
    [DbContext(typeof(ContosoContext))]
    partial class ContosoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", 
                SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hwnn.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();
                    b.Property<string>("FirstName");
                    b.Property<string>("LastName");
                    b.HasKey("Id");
                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("hwnn.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();
                    b.Property<string>("CustomerName");
                    b.HasKey("Id");
                    b.ToTable("Customers");
                });
        }
    }
}
