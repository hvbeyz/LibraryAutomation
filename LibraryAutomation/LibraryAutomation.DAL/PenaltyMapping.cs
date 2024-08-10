using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class PenaltyMapping : IEntityTypeConfiguration<Penalty>
    {
        public void Configure(EntityTypeBuilder<Penalty> builder)
        {
            builder.HasKey(p => p.PenaltyID);
            builder.Property(p => p.PenaltyLevel).IsRequired();
            builder.Property(p => p.PenaltyDate).IsRequired();
            builder.Property(p => p.PenaltyDescription).HasMaxLength(1000);
            builder.Property(p => p.PenaltyScore).IsRequired();

            builder.HasOne(p => p.Member)
                   .WithMany(m => m.Penalties)
                   .HasForeignKey(p => p.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
