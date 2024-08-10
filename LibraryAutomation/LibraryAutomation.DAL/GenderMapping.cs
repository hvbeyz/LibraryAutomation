using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class GenderMapping : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Genders");
            builder.HasKey(g => g.GenderID);
            builder.Property(g => g.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(g => g.Employees)
                   .WithOne(e => e.Gender)
                   .HasForeignKey(e => e.GenderID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(g => g.Members)
                   .WithOne(m => m.Gender)
                   .HasForeignKey(m => m.GenderID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
