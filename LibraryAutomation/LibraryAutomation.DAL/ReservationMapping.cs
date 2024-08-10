using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class ReservationMapping : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => r.ReservationID);
            builder.Property(r => r.ReservationDate).IsRequired();

            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reservations)
                   .HasForeignKey(r => r.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Book)
                   .WithMany(b => b.Reservations)
                   .HasForeignKey(r => r.BookID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
