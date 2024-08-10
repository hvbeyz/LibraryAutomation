using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.EmployeeID);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.BirthDate).IsRequired();
            builder.Property(e => e.EmployeePhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(e => e.AddressEmployee).HasMaxLength(200);
            builder.Property(e => e.IdentityNumber).IsRequired().HasMaxLength(11);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
            builder.Property(e => e.MaritalStatus).IsRequired();

            builder.HasOne(e => e.Branch)
                   .WithMany(b => b.Employees)
                   .HasForeignKey(e => e.BranchID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Gender)
                   .WithMany(g => g.Employees)
                   .HasForeignKey(e => e.GenderID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Role)
                   .WithMany(r => r.Employees)
                   .HasForeignKey(e => e.RoleID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.User)
                   .WithOne(u => u.Employee)
                   .HasForeignKey<User>(u => u.EmployeeID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(e => e.AddressesEmp)
                   .WithOne(ae => ae.Employee)
                   .HasForeignKey(ae => ae.EmployeeID)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
