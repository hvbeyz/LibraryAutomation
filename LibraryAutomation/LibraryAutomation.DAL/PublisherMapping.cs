using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class PublisherMapping : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.PublisherID);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Address).HasMaxLength(200);

            builder.HasMany(p => p.Books)
                   .WithOne(b => b.Publisher)
                   .HasForeignKey(b => b.PublisherID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
