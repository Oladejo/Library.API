﻿using Library.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Services
{
    public interface IBookRepository : IDisposable
    {
        Task<IEnumerable<Book>> GetBooksAsync(Guid authorId);
        Task<Book> GetBookAsync(Guid authorId, Guid bookId);
        void AddBook(Book bookToAdd);
        Task<bool> SaveChangesAsync();
    }
}
