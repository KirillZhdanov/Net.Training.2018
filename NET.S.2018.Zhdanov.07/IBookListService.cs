using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;

namespace Book
{
    interface IBookListService
    {
        /// <summary>
        /// Main list of books
        /// </summary>
        List<Book> ListOfBooks { get; }
        /// <summary>
        /// Storage for list of books
        /// </summary>
        IStorage<Book> Storage { get; }
        /// <summary>
        /// Add book to list and storage
        /// </summary>
        /// <param name="book"></param>
        void AddBook(Book book);
        /// <summary>
        /// Remove book from list and storage
        /// </summary>
        /// <param name="book"></param>
        void RemoveBook(Book book);
        /// <summary>
        /// Get list of books which will found by tag
        /// </summary>
        /// <param name="tagSentese"></param>
        /// <returns></returns>
        List<Book> FindByTag(Book tagSentese);
        /// <summary>
        /// Sort books in list and storage
        /// </summary>
        /// <param name="tagSentese"></param>
        void SortBooksByTag(Book.Tags tagSentese);
    }
}
