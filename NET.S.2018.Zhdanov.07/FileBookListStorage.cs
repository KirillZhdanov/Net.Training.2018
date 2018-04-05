using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
    class FileBookListStorage:IFileBookListStorage
    {
        private string filePath { get; }

        public FileBookListStorage(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath} is not found");
            }

            this.filePath = filePath;
        }

        public List<Book> GetItems()
        {
            List<Book> booksList;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                int count = reader.ReadInt32();

                booksList = new List<Book>(count);

                for (int i = 0; i < count; i++)
                {
                    Book book = ReadBook(reader);

                    booksList.Add(book);
                }
            }

            return booksList;
        }

        public void SaveList(List<Book> books)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                writer.Write(books.Count);

                foreach (Book book in books)
                {
                    WriteBook(book, writer);
                }
            }
        }

        private void WriteBook(Book book, BinaryWriter binaryWriter)
        {
            binaryWriter.Write(book.Isbn);
            binaryWriter.Write(book.Author);
            binaryWriter.Write(book.Name);
            binaryWriter.Write(book.Production);
            binaryWriter.Write(book.Year);
            binaryWriter.Write(book.Page);
            binaryWriter.Write(book.Cost);
        }

        private Book ReadBook(BinaryReader binaryReader)
        {
            string isbn = binaryReader.ReadString();
            string author = binaryReader.ReadString();
            string name = binaryReader.ReadString();
            string production = binaryReader.ReadString();
            int year = binaryReader.ReadInt32();
            int pages = binaryReader.ReadInt32();
            int cost = binaryReader.ReadInt32();

            return new Book(isbn, author, name, production, year, pages, cost);
        }

            
       
    }
}
