using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class PublisherAddressMapping : IEntityTypeConfiguration<PublisherAddress>
    {
        public void Configure(EntityTypeBuilder<PublisherAddress> builder)
        {
            builder.ToTable("PublisherAddress");
            builder.HasKey(p => p.PublisherID);
            builder.Property(a => a.City).IsRequired(false).HasMaxLength(50);
            builder.Property(a => a.Country).IsRequired(false).HasMaxLength(50);
            builder.Property(a => a.PostalCode).IsRequired(false).HasMaxLength(10);


            builder.HasOne(a => a.Publisher)
                   .WithMany(e => e.AddressList)
                   .HasForeignKey(a => a.PublisherID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
