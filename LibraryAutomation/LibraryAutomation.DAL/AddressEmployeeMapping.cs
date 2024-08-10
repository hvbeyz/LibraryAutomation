using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class AddressMappingEmployee : IEntityTypeConfiguration<AddressEmployee>
    {
        public void Configure(EntityTypeBuilder<AddressEmployee> builder)
        {
            builder.ToTable("AddressesEmployee");
            builder.HasKey(a => a.AddressEmployeeID);
            builder.Property(a => a.City).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Country).IsRequired().HasMaxLength(50);
            builder.Property(a => a.PostalCode).HasMaxLength(10);
            builder.Property(a => a.District).HasMaxLength(50);
            builder.Property(a => a.Neighborhood).IsRequired().HasMaxLength(50);

            builder.HasOne(a => a.Employee)
                   .WithMany(e => e.AddressesEmp)
                   .HasForeignKey(a => a.EmployeeID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
