using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LabExam
{
    

    public class PrinterManager
    {
        private readonly ILogger logger;
        public PrinterManager(ILogger logger)
        {
            this.logger = logger;
            Printers = new List<Printer>();
        }

        public static List<Printer> Printers { get; set; }
               

        public static void Add(Printer printer)
        {
          
            if (!Printers.Contains(printer))
            {
                Printers.Add(printer);
                Console.WriteLine("Printer added");
            }
        }
       
        public  void Print(Printer printer)
        {
            
            logger.Log("Print started");
            var fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            if (fileDialog.FileName == String.Empty)
            {
                throw new ArgumentNullException("Path can't be empty");
            }                    
            var f = File.OpenRead(fileDialog.FileName);
            printer.Print(f);
            logger.Log("Print finished");                   


        }
               
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}