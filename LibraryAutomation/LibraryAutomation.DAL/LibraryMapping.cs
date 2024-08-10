using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class LibraryMapping : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(l => l.LibraryID);
            builder.Property(l => l.LibraryName).IsRequired().HasMaxLength(100);

            builder.HasMany(l => l.Branches)
                   .WithOne(b => b.Library)
                   .HasForeignKey(b => b.LibraryID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(l => l.Reports)
                   .WithOne(r => r.Library)
                   .HasForeignKey(r => r.LibraryID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
