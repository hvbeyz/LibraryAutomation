using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserID);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(50);

            builder.HasOne(u => u.Employee)
                   .WithOne(e => e.User)
                   .HasForeignKey<User>(u => u.EmployeeID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Member)
                   .WithOne(m => m.User)
                   .HasForeignKey<User>(u => u.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Branch)
                   .WithMany(b => b.Users)
                   .HasForeignKey(u => u.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Role)
                   .WithMany(r => r.Users)
                   .HasForeignKey(u => u.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Notifications)
                   .WithOne(n => n.User)
                   .HasForeignKey(n => n.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Reservations)
                   .WithOne(r => r.User)
                   .HasForeignKey(r => r.UserID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
