using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class GenreMapping : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");
            builder.HasKey(g => g.GenreID);
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);

            builder.HasMany(g => g.BookGenres)
                   .WithOne(bg => bg.Genre)
                   .HasForeignKey(bg => bg.GenreID);
        }
    }
}
