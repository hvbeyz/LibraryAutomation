using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(b => b.BookID);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(13);
            builder.Property(b => b.PublicationYear).IsRequired();

            builder.HasOne(b => b.Author)
                   .WithMany(a => a.Books)
                   .HasForeignKey(b => b.AuthorID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Publisher)
                   .WithMany(p => p.Books)
                   .HasForeignKey(b => b.PublisherID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.BookGenres)
                   .WithOne(bg => bg.Book)
                   .HasForeignKey(bg => bg.BookID);

            builder.HasMany(b => b.BookCategories)
                   .WithOne(bc => bc.Book)
                   .HasForeignKey(bc => bc.BookID);
        }
    }
}
