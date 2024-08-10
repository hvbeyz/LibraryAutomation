using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class BranchMapping : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");
            builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Location).IsRequired().HasMaxLength(200);

            builder.HasOne(b => b.Library)
                   .WithMany(l => l.Branches)
                   .HasForeignKey(b => b.LibraryID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Users)
                   .WithOne(u => u.Branch)
                   .HasForeignKey(u => u.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Employees)
                   .WithOne(e => e.Branch)
                   .HasForeignKey(e => e.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Members)
                   .WithOne(m => m.Branch)
                   .HasForeignKey(m => m.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
