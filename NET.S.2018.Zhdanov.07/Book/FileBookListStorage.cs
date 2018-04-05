using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
    public class FileBookListStorage:IFileBookListStorage<Book>
    {
        /// <summary>
        /// Reading from file
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Book's fields from file</returns>
        public Book LoadFileData(BinaryReader reader) =>
            new Book(
                isbn:reader.ReadString(),
                author: reader.ReadString(),
                name: reader.ReadString(),
                production: reader.ReadString(),
                year: reader.ReadInt32(),
                page: reader.ReadInt32(),
                cost:reader.ReadInt32()
            );

        /// <summary>
        /// Save book's fields to file
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value">Book for saving</param>
        public void SaveFileData(BinaryWriter writer, Book value)
        {
            writer.Write(value.Isbn);
            writer.Write(value.Author);
            writer.Write(value.Name);
            writer.Write(value.Production);
            writer.Write(value.Year);
            writer.Write(value.Page);
            writer.Write(value.Cost);
        }

    }
}
