using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.CategoryID);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(c => c.BookCategories)
                   .WithOne(bc => bc.Category)
                   .HasForeignKey(bc => bc.CategoryID);
        }
    }
}
