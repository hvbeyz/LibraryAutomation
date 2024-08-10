using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class MemberMapping : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(m => m.MemberID);
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.LastName).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Email).IsRequired().HasMaxLength(100);
            builder.Property(m => m.MemberPhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(m => m.BirthDate).IsRequired();
            builder.Property(m => m.IdentityNumber).IsRequired().HasMaxLength(11);
            builder.Property(m => m.Address).HasMaxLength(200);

            builder.HasOne(m => m.Branch)
                   .WithMany(b => b.Members)
                   .HasForeignKey(m => m.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Gender)
                   .WithMany(g => g.Members)
                   .HasForeignKey(m => m.GenderID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Role)
                   .WithMany(r => r.Members)
                   .HasForeignKey(m => m.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.User)
                   .WithOne(u => u.Member)
                   .HasForeignKey<User>(u => u.MemberID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(m => m.Penalties)
                   .WithOne(p => p.Member)
                   .HasForeignKey(p => p.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Addresses)
                   .WithOne(a => a.Member)
                   .HasForeignKey(a => a.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Loans)
                   .WithOne(l => l.Member)
                   .HasForeignKey(l => l.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
