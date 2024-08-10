using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAutomation.DAL
{
    public class LoanMapping : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => l.LoanID);
            builder.Property(l => l.LoanDate).IsRequired();
            builder.Property(l => l.ReturnDate).IsRequired();

            builder.HasOne(l => l.Member)
                   .WithMany(m => m.Loans)
                   .HasForeignKey(l => l.MemberID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Book)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BookID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Penalty)
                   .WithMany(p => p.Loans)
                   .HasForeignKey(l => l.PenaltyID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
