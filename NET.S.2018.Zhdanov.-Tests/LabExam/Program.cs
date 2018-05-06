using System;

namespace LabExam
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Select your choice:");
            Console.WriteLine("1:Add new printer");
            Console.WriteLine("2:Print on Canon");
            Console.WriteLine("3:Print on Epson");

            while (true)
            { 
                
             var key = Console.ReadKey();

                if (key.Key == ConsoleKey.D1)
                {
                    CreatePrinter();
                }

                if (key.Key == ConsoleKey.D2)
                {
                Print(new Printer("Canon","123x"));
                }

                 if (key.Key == ConsoleKey.D3)
                 {
                Print(new Printer("Epson","231"));
                 }
               
                for (int i = 0; i < PrinterManager.Printers.Count; i++)
                {
                    Console.WriteLine($"New printers : {i+1} \n  Name:  {PrinterManager.Printers[i].Name } \n  Model: {PrinterManager.Printers[i].Model}");
                }
                
            }
        }

        private static readonly ILogger logger=new Logger("log.txt");
        private static PrinterManager printerManager = new PrinterManager(logger);
        #region Private methods
        /// <summary>
        /// Print Method
        /// </summary>
        /// <param name="printer"></param>
        private static   void Print(Printer printer)
        {
            printerManager.Print(printer);
            logger.Log($"Printed on :{printer.Name},{printer.Model}");
            
        }

        
        /// <summary>
        /// Method to create printer
        /// </summary>
        private static void CreatePrinter()
        {
            Console.WriteLine("Enter printer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter printer model");
            string model = Console.ReadLine();

            PrinterManager.Add(new Printer(name,model));
        }
        #endregion
    }
}
