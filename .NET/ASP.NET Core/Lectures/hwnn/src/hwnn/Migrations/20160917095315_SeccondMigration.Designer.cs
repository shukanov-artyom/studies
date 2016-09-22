using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using hwnn.Models;

namespace hwnn.Migrations
{
    [DbContext(typeof(ContosoContext))]
    [Migration("20160917095315_SeccondMigration")]
    partial class SeccondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hwnn.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("LastName")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("hwnn.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int?>("CustomerContactId");

                    b.Property<string>("CustomerName")
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerContactId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("hwnn.Models.Customer", b =>
                {
                    b.HasOne("hwnn.Models.Contact", "CustomerContact")
                        .WithMany()
                        .HasForeignKey("CustomerContactId");
                });
        }
    }
}
