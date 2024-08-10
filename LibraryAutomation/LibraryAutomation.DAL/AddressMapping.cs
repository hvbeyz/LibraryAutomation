using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(a => a.AddressID);
            builder.Property(a => a.City).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Country).IsRequired().HasMaxLength(50);
            builder.Property(a => a.PostalCode).HasMaxLength(10);
            builder.Property(a => a.District).HasMaxLength(50);
            builder.Property(a => a.Neighborhood).IsRequired().HasMaxLength(50);

            builder.HasOne(a => a.Member)
                   .WithMany(m => m.Addresses)
                   .HasForeignKey(a => a.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
