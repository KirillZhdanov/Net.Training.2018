using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
   public interface IFileBookListStorage<T>
    {
        /// <summary>
        /// To file
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        void SaveFileData(BinaryWriter writer, T value);
        /// <summary>
        /// Load data 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        T LoadFileData(BinaryReader reader);


    }
}
