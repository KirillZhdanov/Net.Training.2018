using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book:IComparable<Book>
    {
        #region Consructor
        /// <summary>
        /// Consructor
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="author"></param>
        /// <param name="production"></param>
        /// <param name="year"></param>
        /// <param name="page"></param>
        /// <param name="cost"></param>
        public Book(string isbn,string name,string author,string production,int year,int page,int cost)
        {
            Isbn = isbn;
            Name = name;
            Author = author;
            Production = production;
            Year = year;
            Page = page;
            Cost = cost;
        }
        #endregion

        #region Properties
        public string Isbn { get; }
        public string Name { get; }
        public string Author { get; }
        public string Production { get; }
        public int Year { get; }
        public int Page { get; }
        public int Cost { get; }
        #endregion
        public enum Tags
        {
            Isbn,
            Name,
            Author,
            Production,
            Year,
            Page,
            Cost

        }
        public int CompareTo(Book other) =>
           IsCompareTo(other);
        private int IsCompareTo(Book other) =>
            Name.CompareTo(other.Name);
       
    }
}
