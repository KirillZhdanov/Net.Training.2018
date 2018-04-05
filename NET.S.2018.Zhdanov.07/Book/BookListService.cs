using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;




namespace Book
{
   public class BookListService:IBookListService
    {

       
        /// <summary>
        /// Logger
        /// </summary>
        private static Logger logger=LogManager.GetCurrentClassLogger();
        public IStorage<Book> Storage { get; private set; }
       

        #region Container
        /// <summary>
        /// Container
        /// </summary>
        /// <param name="storage"></param>
        public BookListService(string Path,IStorage<Book> storage)
        {
            Storage = storage;

            ListOfBooks = Storage.Items as List<Book>;
            
        }
        #endregion

        #region Public Methods
        public List<Book> ListOfBooks { get; set; }

        public void AddBook(Book book)
        {
            if (HasFindedItem(book))
            {

                ListOfBooks.Add(book);

            }
            else
                throw new InvalidOperationException("This book is already added");
        }

        public List<Book> FindByTag(Book tagSentese)
        {
            List<Book> result=new List<Book>();
          
            foreach(Book x in ListOfBooks)
            {
                if (x == tagSentese)
                    result.Add(x);
                else
                    throw new InvalidOperationException("Sorry but we can't find this book by tag.");
            }
            return result;
        }

        public void RemoveBook(Book book)
        {
            if (HasFindedItem(book))
            {
                ListOfBooks.Remove(book);
            }
            else
                throw new InvalidOperationException("You can't remove book,which doesn't exist");


            WriteNewListToFile();
        }

        public void SortBooksByTag(Book.Tags tagSentese)
        {
          
            SortByTag(tagSentese);
            WriteNewListToFile();
            
        }
     

        #endregion


        #region Private Methods
        private bool HasFindedItem(Book book)
        {
            bool isExist;
            try
            {
                
                isExist = ListOfBooks.Contains(book);
            }
            catch (ArgumentNullException ex)
            {
                logger.Error("Item isn't exist");
                throw ex;
            }

            return isExist;
        }

        private IEnumerable<Book> SortByTag(Book.Tags tag)
        {
            switch (tag)
            {
                case (Book.Tags.Name):
                    {
                        return ListOfBooks.OrderBy((t) => t.Name);
                    }

                case (Book.Tags.Author):
                    {
                        return ListOfBooks.OrderBy((t) => t.Author);
                    }

                case (Book.Tags.Cost):
                    {
                        return ListOfBooks.OrderBy((t) => t.Cost);
                    }

                case (Book.Tags.Isbn):
                    {
                        return ListOfBooks.OrderBy((t) => t.Isbn);
                    }

                case (Book.Tags.Production):
                    {

                        return ListOfBooks.OrderBy((t) => t.Production);
                    }

                case (Book.Tags.Year):
                    {
                        return ListOfBooks.OrderBy((t) => t.Year);
                    }

                default:
                    {
                        throw new ArgumentException(nameof(tag));
                    }
            }
        }

        private void WriteNewListToFile()
        {
            Storage.Clear();
            Storage.SaveList(ListOfBooks);
        }


        #endregion

    }
}
