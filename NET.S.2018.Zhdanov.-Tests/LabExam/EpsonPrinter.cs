using System;
using System.IO;

namespace LabExam
{
    internal class EpsonPrinter:AbstractPrinter
    {
        public EpsonPrinter()
        {
            Model = "231";
            Name = "Epson";
        }
               

        public  string Name { get; set; }

        public  string Model { get; set; }
    }
}