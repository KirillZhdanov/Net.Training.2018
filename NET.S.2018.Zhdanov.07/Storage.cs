using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Book
{
    class Storage<T>:IStorage<T>
    {
        #region Private Readonly Fields

        private static Logger logger=LogManager.GetCurrentClassLogger();

        #endregion

        #region Constructor

        /// <summary>
        /// Try exist file by filepath and initialize values
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="data"></param>
        public Storage(string filePath, IFileBookListStorage<T> data)
        {
            

            CheckFilePath(filePath);
            Data = data;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Path of file
        /// </summary>
        public string FilePath { get; private set; }
        /// <summary>
        /// Read/write from/to file
        /// </summary>
        public IFileBookListStorage<T> Data { get; private set; }

        /// <summary>
        /// Get list of items from file
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Items
        {
            get
            {
                IEnumerable<T> result;
                try
                {
                    result = GetList();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Error($"Try open file from {FilePath} but not found: {ex}");
                    throw ex;
                }

                return result;
            }
        }
        #endregion

        #region Public Methods

       

        /// <summary>
        /// Add item to file
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(T item)
        {
            if (item == null)
                throw new ArgumentNullException();

            try
            {
                AddItemToFile(item);
            }
            catch (NotSupportedException ex)
            {
                logger.Error($"If read fail: {ex}");
                throw;
            }
        }

        /// <summary>
        /// Clear file from data
        /// </summary>
        public void Clear()
        {
            File.WriteAllText(FilePath, string.Empty);
        }

        /// <summary>
        /// Save list of data to file
        /// </summary>
        /// <param name="list"></param>
        public void SaveList(IEnumerable<T> list)
        {
            SaveListToFile(list);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Try exist file by filepath
        /// </summary>
        /// <param name="filePath"></param>
        private void CheckFilePath(string filePath)
        {
            logger.Debug("Start CheckFilePath method");

            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("Argument is null or empty");

            if (!File.Exists(filePath))
                throw new FileNotFoundException(nameof(FilePath));

            logger.Debug("End CheckFilePath method");

            FilePath = filePath;
        }

        /// <summary>
        /// Get list of items from file
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T> GetList()
        {
            logger.Debug("Start GetList");

            var list = new List<T>();
            var fileStream = File.Open(FilePath, FileMode.Open, FileAccess.Read);
            using (var reader = new BinaryReader(fileStream))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    list.Add(Data.LoadFileData(reader));
                }
            }

            logger.Debug("End GetList");

            return list;
        }

        /// <summary>
        /// Add item to file
        /// </summary>
        /// <param name="item"></param>
        private void AddItemToFile(T item)
        {
            logger.Debug("Start Add");

            var fileStream = File.Open(FilePath, FileMode.Append, FileAccess.Write);
            using (var writer = new BinaryWriter(fileStream))
            {
                Data.SaveFileData(writer, item);
            }

            logger.Debug("End Add");
        }

        /// <summary>
        /// Save list of data to file
        /// </summary>
        /// <param name="list"></param>
        public void SaveListToFile(IEnumerable<T> list)
        {
            logger.Debug("Start Save");

            var fileStream = File.Open(FilePath, FileMode.Truncate, FileAccess.Write);
            using (var writer = new BinaryWriter(fileStream))
            {
                foreach (var item in list)
                {
                    Data.SaveFileData(writer, item);
                }
            }

            logger.Debug("End SaveListToFile method");
        }

        #endregion
    }
}
