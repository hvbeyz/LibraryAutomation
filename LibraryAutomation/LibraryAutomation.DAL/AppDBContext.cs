using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.DAL
{
    public class AppDBContext : DbContext
    {
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<PublisherAddress> PublisherAddresses { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<AddressEmployee> AddressesEmployee { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UKI0AK1;Initial Catalog=LibraryDB;User ID=sa;Password=123;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReportTypeMapping());
            modelBuilder.ApplyConfiguration(new PublisherAddressMapping());
            modelBuilder.ApplyConfiguration(new AddressMappingEmployee());
            modelBuilder.ApplyConfiguration(new PenaltyMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new LibraryMapping());
            modelBuilder.ApplyConfiguration(new BranchMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new EmployeeMapping());
            modelBuilder.ApplyConfiguration(new MemberMapping());
            modelBuilder.ApplyConfiguration(new GenderMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new LoanMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new PublisherMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new GenreMapping());
            modelBuilder.ApplyConfiguration(new ReportMapping());
            modelBuilder.ApplyConfiguration(new NotificationMapping());
            modelBuilder.ApplyConfiguration(new ReservationMapping());
            modelBuilder.ApplyConfiguration(new BookCategoryMapping());
            modelBuilder.ApplyConfiguration(new BookGenreMapping());

            modelBuilder.Entity<Genre>().HasData(
        new Genre { GenreID = 1, Name = "Science Fiction" },
        new Genre { GenreID = 2, Name = "Fantasy" }
    );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Fiction" },
                new Category { CategoryID = 2, Name = "Non-Fiction" }
            );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { GenderID = 1, Name = "Erkek" },
                new Gender { GenderID = 2, Name = "Kadın" }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, Name = "Admin" },
                new Role { RoleID = 2, Name = "Member" },
                new Role { RoleID = 3, Name = "Employee" }
            );

            modelBuilder.Entity<Library>().HasData(
                new Library { LibraryID = 1, LibraryName = "Main Library" }
            );

            modelBuilder.Entity<Branch>().HasData(
                new Branch { BranchID = 1, Name = "Main Branch", Location = "Main City", LibraryID = 1 }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorID = 1, Name = "Isaac Asimov" },
                new Author { AuthorID = 2, Name = "J.R.R. Tolkien" }
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherID = 1, Name = "Penguin Random House", Address = "New York" },
                new Publisher { PublisherID = 2, Name = "HarperCollins", Address = "New York" }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberID = 1,
                    Name = "Tom",
                    LastName = "Doe",
                    Email = "Tomdoe@example.com",
                    MemberPhoneNumber = "123456789",
                    BirthDate = new DateTime(1990, 1, 1),
                    Address = "123 Main St",
                    IdentityNumber = "11111111111",
                    BranchID = 1,
                    GenderID = 1,
                    RoleID = 2
                },
                  new Member
                  {
                      MemberID = 2,
                      Name = "Samantha",
                      LastName = "Doe",
                      Email = "Tomdoe@example.com",
                      MemberPhoneNumber = "123456789",
                      BirthDate = new DateTime(1990, 1, 1),
                      Address = "123 Main St",
                      IdentityNumber = "11111111111",
                      BranchID = 1,
                      GenderID = 2,
                      RoleID = 2
                  }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    Name = "Jane",
                    LastName = "Smith",
                    BirthDate = new DateTime(1985, 5, 15),
                    EmployeePhoneNumber = "987654321",
                    AddressEmployee = "456 Elm St",
                    IdentityNumber = "22222222222",
                    MaritalStatus = 1,
                    Email = "janesmith@example.com",
                    BranchID = 1,
                    GenderID = 1,
                    RoleID = 1
                },
                new Employee
                {
                    EmployeeID = 2,
                    Name = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 1, 1),
                    EmployeePhoneNumber = "555-555-555",
                    AddressEmployee = "123 Main St",
                    IdentityNumber = "33333333333",
                    MaritalStatus = 1,
                    Email = "john.doe@example.com",
                    BranchID = 1,
                    GenderID = 1,
                    RoleID = 3
                }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressID = 1,
                    City = "New York",
                    Country = "USA",
                    PostalCode = "10001",
                    District = "Manhattan",
                    Neighborhood = "Chelsea",
                    MemberID = 1
                }
            );

            modelBuilder.Entity<AddressEmployee>().HasData(
                new AddressEmployee
                {
                    AddressEmployeeID = 1,
                    City = "Main City",
                    Country = "Main Country",
                    PostalCode = "555-555",
                    District = "Main District",
                    Neighborhood = "Main Neighborhood",
                    EmployeeID = 1
                },

                new AddressEmployee
                {
                    AddressEmployeeID = 2,
                    City = "Second City",
                    Country = "Second Country",
                    PostalCode = "666-666",
                    District = "Second District",
                    Neighborhood = "Second Neighborhood",
                    EmployeeID = 2
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    UserName = "Admin",
                    Password = "Admin",
                    BranchID = 1,
                    RoleID = 1,
                    EmployeeID = 1,
                    MemberID = null
                },
                new User
                {
                    UserID = 3,
                    UserName = "user",
                    Password = "user123",
                    RoleID = 2,
                    BranchID = 1,
                    EmployeeID = null,
                    MemberID = 1
                },
                new User
                {
                    UserID = 2,
                    UserName = "emplo",
                    Password = "emplo123",
                    RoleID = 3,
                    BranchID = 1,
                    EmployeeID = 2,
                    MemberID = null
                },
                new User
                {
                    UserID = 4,
                    UserName = "user2",
                    Password = "user2123",
                    RoleID = 3,
                    BranchID = 1,
                    EmployeeID = null,
                    MemberID = 2
                }
            );

            modelBuilder.Entity<PublisherAddress>().HasData(
                new PublisherAddress { PublisherAddressID = 1, PublisherID = 1, City = "DefaultCity", Country = "DefaultCountry", PostalCode = "12345" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookID = 1,
                    Title = "Foundation",
                    ISBN = "123456789",
                    PublicationYear = new DateTime(1951, 1, 1),
                    AuthorID = 1,
                    PublisherID = 1,
                    IsHere=false
                },
                new Book
                {
                    BookID = 2,
                    Title = "The Hobbit",
                    ISBN = "987654321",
                    PublicationYear = new DateTime(1937, 1, 1),
                    AuthorID = 2,
                    PublisherID = 2,
                    IsHere = true
                }
            );

            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre { BookGenreID = 1, BookID = 1, GenreID = 1 },
                new BookGenre { BookGenreID = 2, BookID = 2, GenreID = 2 }
            );

            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { BookCategoryID = 1, BookID = 1, CategoryID = 1 },
                new BookCategory { BookCategoryID = 2, BookID = 2, CategoryID = 2 }
            );

            modelBuilder.Entity<Loan>().HasData(
                new Loan
                {
                    LoanID = 1,
                    LoanDate = DateTime.Now,
                    ReturnDate = DateTime.Now.AddDays(14),
                    MemberID = 1,
                    BookID = 1,
                    PenaltyID = 1
                }
            );

            modelBuilder.Entity<Penalty>().HasData(
                new Penalty
                {
                    PenaltyID = 1,
                    PenaltyLevel = 1,
                    PenaltyDate = DateTime.Now,
                    PenaltyDescription = "Late return",
                    PenaltyScore = 10,
                    MemberID = 1
                }
            );

            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    NotificationID = 1,
                    Message = "Your book is overdue",
                    NotificationDate = DateTime.Now,
                    UserID = 1
                }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    ReservationID = 1,
                    ReservationDate = DateTime.Now,
                    UserID = 1,
                    BookID = 1
                }
            );

            modelBuilder.Entity<ReportType>().HasData(
                new ReportType
                {
                    ReportTypeID = 1,
                    ReportName = "Monthly Report"
                }
            );

            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    ReportID = 1,
                    Type = "Monthly",
                    CreationDate = DateTime.Now,
                    LibraryID = 1,
                    ReportTypeID = 1
                }
            );

        }
    }
}
