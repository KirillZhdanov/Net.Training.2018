using System;
using System.IO;

namespace LabExam
{
    public abstract class AbstractPrinter
    {
        public event EventHandler<IfPrinted> IfEnd = delegate { };
        public event EventHandler<IfPrintStarted> IfStart = delegate { };
        /// <summary>
        /// Print Method
        /// </summary>
        /// <param name="stream"></param>
        public void Print(Stream stream)
        {
            StartPrinting();
            for (int i = 0; i < stream.Length; i++)
            {
                // simulate printing
                Console.WriteLine(stream.ReadByte());
            }
            EndPrinting();
        }
       
        private  void StartPrinting() => IfStart?.Invoke(this, new IfPrintStarted(this, "Printing started"));
        private  void EndPrinting() => IfEnd?.Invoke(this, new IfPrinted(this, "Printing ended"));

    }
}
