// <auto-generated />
using LGC_Check_In.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LGCCheckIn.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230117024416_Phone_To_String")]
    partial class PhoneToString
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("LGC_Check_In.Models.Children", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GeneratedCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuardianPhone")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecordID");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("LGC_Check_In.Models.Guardian", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("RecordID");

                    b.ToTable("Guardians");
                });
#pragma warning restore 612, 618
        }
    }
}
