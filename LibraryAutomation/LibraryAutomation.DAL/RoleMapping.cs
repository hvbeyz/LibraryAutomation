using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleID);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(r => r.Employees)
                   .WithOne(e => e.Role)
                   .HasForeignKey(e => e.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(r => r.Members)
                   .WithOne(m => m.Role)
                   .HasForeignKey(m => m.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(r => r.Users)
                   .WithOne(u => u.Role)
                   .HasForeignKey(u => u.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
