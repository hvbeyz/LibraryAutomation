using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryAutomation.DAL
{
    public class ReportTypeMapping : IEntityTypeConfiguration<ReportType>
    {
        public void Configure(EntityTypeBuilder<ReportType> builder)
        {
            builder.HasKey(rt => rt.ReportTypeID);
            builder.Property(rt=> rt.ReportName);
            builder.HasMany(rt => rt.Reports).WithOne(rt => rt.ReportType).HasForeignKey(rt => rt.ReportTypeID);
        }
    }
}
