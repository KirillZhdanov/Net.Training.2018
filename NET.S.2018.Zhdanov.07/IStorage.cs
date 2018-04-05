using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    interface IStorage<T>
    {
        /// <summary>
        /// Returns all finding from list
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Items { get; }

        /// <summary>
        /// Add item to file
        /// </summary>
        /// <param name="item"></param>
        void AddItem(T item);
        /// <summary>
        /// Clear file from data
        /// </summary>
        void Clear();
        /// <summary>
        /// Save list of data to file
        /// </summary>
        /// <param name="list"></param>
        void SaveList(IEnumerable<T> list);
    }
}
