namespace BookaholicFin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookaholicFin.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookaholicFin.Models.BookStoreEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BookaholicFin.Models.BookStoreEntities";
        }

        protected override void Seed(BookaholicFin.Models.BookStoreEntities context)
        {
            context.Genres.AddOrUpdate(x => x.GenreId,
                new Genre() { GenreId = 1, Name = "Classic", Description= "A classic stands the test of time. The work is usually considered to be a representation of the period in which it was written; and the work merits lasting recognition. In other words, if the book was published in the recent past, the work is not a classic. A classic has a certain universal appeal. Great works of literature touch us to our very core beings--partly because they integrate themes that are understood by readers from a wide range of backgrounds and levels of experience. Themes of love, hate, death, life, and faith touch upon some of our most basic emotional responses." },
                new Genre() { GenreId = 2, Name = "Fantasy", Description= "Fantasy is a genre that uses magic and other supernatural forms as a primary element of plot, theme, and/or setting. Fantasy is generally distinguished from science fiction and horror by the expectation that it steers clear of technological and macabre themes, respectively, though there is a great deal of overlap between the three (collectively known as speculative fiction or science fiction/fantasy). In its broadest sense, fantasy comprises works by many writers, artists, filmmakers and musicians, from ancient myths and legends to many recent works embraced by a wide audience today, including young adults, most of whom are represented by the works below." }
            );

            context.Authors.AddOrUpdate(x =>x.AuthorId,
                new Author() { AuthorId = 1, Name = "Jane Austen" },
                new Author() { AuthorId = 2, Name = "Anne Bronte" },
                new Author() { AuthorId = 3, Name = "Charles Dickens" },
                new Author() { AuthorId = 4, Name = "J. K. Rowling" },
                new Author() { AuthorId = 5, Name = "Neil Gaiman"}
            );

            context.Books.AddOrUpdate(x=>x.BookId,
                new Book() { BookId = 1, Title = "Pride and Prejudice", Price = 90, GenreId = 1, AuthorId = 1, CoverArtUrl = "/Content/books/Pride-and-Prejudice.jpg" },
                new Book() { BookId = 2, Title = "Perssuasion", Price = 80, GenreId = 1, AuthorId = 1, CoverArtUrl = "/Content/books/Persuasion.jpg" },
                new Book() { BookId = 3, Title = "Agnes Grey",  Price = 50, GenreId = 1, AuthorId = 2, CoverArtUrl = "/Content/books/Agnes-Grey.jpg" },
                new Book() { BookId = 4, Title = "The Tenant Of Wildfell Hall", GenreId = 1, AuthorId = 2, Price = 60, CoverArtUrl = "/Content/books/The-tenant-of-Wildfell-Hall.jpg" },
                new Book() { BookId = 5, Title = "A Tale Of Two Cities", GenreId = 1, AuthorId = 3, Price = 65,  CoverArtUrl = "/Content/books/A-Tale-of-Two-Cities.jpg" },
                new Book() { BookId = 6, Title = "A Christmas Caroll", GenreId = 1, AuthorId = 3, Price = 56,  CoverArtUrl = "/Content/books/A-Christmas-Caroll.jpg" },
                new Book() { BookId = 7, Title = "Harry Potter and the philospher's stone", GenreId = 2, AuthorId = 4, Price = 87, CoverArtUrl = "/Content/books/Harry-Potter-the-Stone.jpg" },
                new Book() { BookId = 8, Title = "Harry Potter and the chamber of secrets", GenreId = 2, AuthorId = 4, Price = 99, CoverArtUrl = "/Content/books/Harry-Potter-and-the-Chamber-of-Secrets.jpg" },
                new Book() { BookId = 9, Title = "Coraline", Price = 45, GenreId = 2, AuthorId = 5, CoverArtUrl = "/Content/books/Coraline.jpg" },
                new Book() { BookId = 10, Title = "American Gods", Price = 28, GenreId = 2, AuthorId = 5, CoverArtUrl = "/Content/books/American-Gods.jpg" }
            );
        }
    }
}
