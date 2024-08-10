using LibraryAutomation.DAL;
using LibraryAutomation.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.BAL
{
    public class BookServices
    {
        private readonly AppDBContext _dbContext;

        public BookServices()
        {
            _dbContext = new AppDBContext();
        }

        public List<BookViewModel> GetAllBooks()
        {
            return _dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Loans)
                .Include(b => b.Reservations)
                .Include(b => b.BookGenres).ThenInclude(bg => bg.Genre)
                .Include(b => b.BookCategories).ThenInclude(bc => bc.Category)
                .Select(b => new BookViewModel
                {
                    BookID = b.BookID,
                    Title = b.Title,
                    ISBN = b.ISBN,
                    PublicationYear = b.PublicationYear,
                    AuthorName = b.Author.Name,
                    PublisherName = b.Publisher.Name,
                    Categories = string.Join(", ", b.BookCategories.Select(bc => bc.Category.Name)),
                    Genres = string.Join(", ", b.BookGenres.Select(bg => bg.Genre.Name)),
                    IsHere = b.IsHere
                })
                .ToList();
        }

        public void AddBook(string title, string isbn, DateTime publicationYear, string authorName, string genres, string categories, int publisherID)
        {
            var author = GetOrCreateAuthor(authorName);

            var book = new Book
            {
                Title = title,
                ISBN = isbn,
                PublicationYear = publicationYear,
                AuthorID = author.AuthorID,
                PublisherID = publisherID,
                IsHere = true
            };

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            AddGenresToBook(book.BookID, genres);
            AddCategoriesToBook(book.BookID, categories);

            _dbContext.SaveChanges();
        }

        private void AddCategoriesToBook(int bookID, string categories)
        {
            var categoryList = categories.Split(',').Select(c => c.Trim()).ToList();
            foreach (var categoryName in categoryList)
            {
                var category = _dbContext.Categories.FirstOrDefault(c => c.Name == categoryName)
                               ?? new Category { Name = categoryName };

                if (category.CategoryID == 0) _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();

                var bookCategory = new BookCategory { BookID = bookID, CategoryID = category.CategoryID };
                _dbContext.BookCategories.Add(bookCategory);
            }
        }

        private void AddGenresToBook(int bookID, string genres)
        {
            var genreList = genres.Split(',').Select(g => g.Trim()).ToList();
            foreach (var genreName in genreList)
            {
                var genre = _dbContext.Genres.FirstOrDefault(g => g.Name == genreName)
                            ?? new Genre { Name = genreName };

                if (genre.GenreID == 0) _dbContext.Genres.Add(genre);
                _dbContext.SaveChanges();

                var bookGenre = new BookGenre { BookID = bookID, GenreID = genre.GenreID };
                _dbContext.BookGenres.Add(bookGenre);
            }
        }

        private Author GetOrCreateAuthor(string authorName)
        {
            var author = _dbContext.Authors.FirstOrDefault(a => a.Name == authorName)
                         ?? new Author { Name = authorName };

            if (author.AuthorID == 0) _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();

            return author;
        }

        public List<Publisher> GetAllPublishers()
        {
            return _dbContext.Publishers.Include(p => p.AddressList).ToList();
        }

        public List<PublisherAddress> GetAllPublisherAddresses()
        {
            return _dbContext.PublisherAddresses.ToList();
        }

        public void AddPublisher(Publisher publisher)
        {
            _dbContext.Publishers.Add(publisher);
            _dbContext.SaveChanges();
        }

        public void AddPublisherAddress(PublisherAddress address)
        {
            _dbContext.PublisherAddresses.Add(address);
            _dbContext.SaveChanges();
        }

        public void UpdatePublisher(Publisher publisher)
        {
            _dbContext.Publishers.Update(publisher);
            _dbContext.SaveChanges();
        }

        public void UpdatePublisherAddress(PublisherAddress address)
        {
            _dbContext.PublisherAddresses.Update(address);
            _dbContext.SaveChanges();
        }

        public void DeletePublisher(int publisherId)
        {
            var publisher = _dbContext.Publishers.Include(p => p.AddressList).FirstOrDefault(p => p.PublisherID == publisherId);
            if (publisher != null)
            {
                _dbContext.PublisherAddresses.RemoveRange(publisher.AddressList);
                _dbContext.Publishers.Remove(publisher);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteBook(int bookID)
        {
            var book = _dbContext.Books.Find(bookID);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public BookViewModel? GetBookById(int bookId)
        {
            var book = _dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.BookGenres).ThenInclude(bg => bg.Genre)
                .Include(b => b.BookCategories).ThenInclude(bc => bc.Category)
                .FirstOrDefault(b => b.BookID == bookId);

            if (book == null) return null;

            return new BookViewModel
            {
                BookID = book.BookID,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationYear = book.PublicationYear,
                AuthorName = book.Author.Name,
                PublisherName = book.Publisher.Name,
                Categories = string.Join(", ", book.BookCategories.Select(bc => bc.Category.Name)),
                Genres = string.Join(", ", book.BookGenres.Select(bg => bg.Genre.Name)),
                IsHere = book.IsHere
            };
        }

        public void UpdateBook(int bookId, string title, string isbn, DateTime publicationYear, string authorName, string genres, string categories, int publisherID)
        {
            var book = _dbContext.Books.Include(b => b.BookGenres).Include(b => b.BookCategories).FirstOrDefault(b => b.BookID == bookId);

            if (book != null)
            {
                book.Title = title;
                book.ISBN = isbn;
                book.PublicationYear = publicationYear;
                book.AuthorID = GetOrCreateAuthor(authorName).AuthorID;
                book.PublisherID = publisherID;

                book.BookCategories.Clear();
                AddCategoriesToBook(book.BookID, categories);

                book.BookGenres.Clear();
                AddGenresToBook(book.BookID, genres);

                _dbContext.SaveChanges();
            }
        }
    }
}
