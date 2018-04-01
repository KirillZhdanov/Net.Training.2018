using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace StreamsDemo
{
    // C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015
    // Chapter 15: Streams and I/O
    // Chapter 6: Framework Fundamentals - Text Encodings and Unicode
    // https://msdn.microsoft.com/ru-ru/library/system.text.encoding(v=vs.110).aspx

    public static class StreamsExtension
    {

        #region Public members

        #region TODO: Implement by byte copy logic using class FileStream as a backing store stream .

        public static int ByByteCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            FileStream buffer = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            byte[] byteSource = new byte[buffer.Length];
            buffer.Read(byteSource, 0, byteSource.Length);
            buffer.Dispose();

            FileStream destination = new FileStream(destinationPath, FileMode.OpenOrCreate, FileAccess.Write);
            destination.Write(byteSource, 0, byteSource.Length);
            int resInBytes = (int)destination.Length;
            destination.Dispose();

            return resInBytes;
            
           
        }

        #endregion

        #region TODO: Implement by byte copy logic using class MemoryStream as a backing store stream.

        public static int InMemoryByByteCopy(string sourcePath, string destinationPath)
        {
            
            // TODO: step 1. Use StreamReader to read entire file in string
            // TODO: step 2. Create byte array on base string content - use  System.Text.Encoding class
            // TODO: step 3. Use MemoryStream instance to read from byte array (from step 2)
            // TODO: step 4. Use MemoryStream instance (from step 3) to write it content in new byte array
            // TODO: step 5. Use Encoding class instance (from step 2) to create char array on byte array content
            // TODO: step 6. Use StreamWriter here to write char array content in new file

            InputValidation(sourcePath, destinationPath);

            StreamReader streamReader = new StreamReader(sourcePath);
            byte [] data = Encoding.UTF8.GetBytes(streamReader.ReadToEnd()) ;
            MemoryStream mStream = new MemoryStream(data, 0, data.Length);
            mStream.Write(data, 0, data.Length);
            char[] byteArrayContent = Encoding.UTF8.GetChars(data);

            StreamWriter streamWriter = new StreamWriter(destinationPath);
            streamWriter.Write(byteArrayContent);
            int resInBytes = streamWriter.Encoding.GetByteCount(byteArrayContent);

            return resInBytes;

        }

        #endregion

        #region TODO: Implement by block copy logic using FileStream buffer.

        public static int ByBlockCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            int resInBytes = 0;

            using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                using (FileStream destination = new FileStream(destinationPath, FileMode.Open))
                {
                    destination.Write(data, 0, data.Length);
                    resInBytes = Convert.ToInt32(destination.Length);
                }
            }
            return resInBytes;
        }

        #endregion

        #region TODO: Implement by block copy logic using MemoryStream.

        public static int InMemoryByBlockCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);
            int resInBytes = 0;
            StreamReader streamReader = new StreamReader(sourcePath);
            byte[] data = new byte[sourcePath.Length];
          
            using (MemoryStream memoryStream = new MemoryStream(data, 0, data.Length))
            {
                memoryStream.Write(data, 0, data.Length);
                Buffer.BlockCopy(data, 0, memoryStream.ToArray(), 0, memoryStream.ToArray().Length);
                StreamWriter streamWriter = new StreamWriter(destinationPath);
                streamWriter.Write(Encoding.UTF8.GetChars(memoryStream.ToArray()));
                resInBytes = memoryStream.ToArray().Length;
                streamWriter.Close();
            }

            return resInBytes;

            // TODO: Use InMemoryByByteCopy method's approach
          
        }

        #endregion

        #region TODO: Implement by block copy logic using class-decorator BufferedStream.

        public static int BufferedCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);
            int resInBytes = 0;

            FileStream source = File.OpenRead(sourcePath);
            byte[] data = new byte[source.Length];
            source.Read(data, 0, data.Length);
           
            using (FileStream fs = File.OpenRead(destinationPath))
            using (BufferedStream buff = new BufferedStream(fs, sourcePath.Length))  
            {

                buff.Write(data, 0, data.Length);
                resInBytes = Convert.ToInt32(fs.Length);
            }
            return resInBytes;
        }

        #endregion

        #region TODO: Implement by line copy logic using FileStream and classes text-adapters StreamReader/StreamWriter

        public static int ByLineCopy(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);
            using (StreamReader streamReader = new StreamReader(sourcePath))
                using(StreamWriter sWriter=new StreamWriter(destinationPath))
            {
                sWriter.Write(streamReader.ReadToEnd());
            }
            byte[] data = File.ReadAllBytes(destinationPath);
            return data.Length;
        }

        #endregion

        #region TODO: Implement content comparison logic of two files 

        public static bool IsContentEquals(string sourcePath, string destinationPath)
        {
            InputValidation(sourcePath, destinationPath);

            bool isEqual =File.ReadAllBytes(sourcePath).Equals(File.ReadAllBytes(destinationPath));
            return isEqual;
        }

        #endregion

        #endregion

        #region Private members

        #region TODO: Implement validation logic

        private static void InputValidation(string sourcePath, string destinationPath)
        {
            if (sourcePath == null || destinationPath == null)
                throw new ArgumentNullException("SourcePath and Destination path should be init");

        }

        #endregion

        #endregion

    }
}
