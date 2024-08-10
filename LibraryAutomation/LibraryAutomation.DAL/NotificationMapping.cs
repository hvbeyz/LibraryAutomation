using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class NotificationMapping : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.NotificationID);
            builder.Property(n => n.Message).IsRequired().HasMaxLength(500);
            builder.Property(n => n.NotificationDate).IsRequired();

            builder.HasOne(n => n.User)
                   .WithMany(u => u.Notifications)
                   .HasForeignKey(n => n.UserID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
