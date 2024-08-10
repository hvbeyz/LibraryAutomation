using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class ReportMapping : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(r => r.ReportID);
            builder.Property(r => r.Type).IsRequired().HasMaxLength(100);
            builder.Property(r => r.CreationDate).IsRequired();

            builder.HasOne(r => r.Library)
                   .WithMany(l => l.Reports)
                   .HasForeignKey(r => r.LibraryID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r =>r.ReportType).WithMany(rt=>rt.Reports).HasForeignKey(r => r.ReportTypeID);
        }
    }
}
