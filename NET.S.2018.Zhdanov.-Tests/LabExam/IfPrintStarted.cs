using System;

namespace LabExam
{
    /// <summary>
    /// Event if print is started
    /// </summary>
    public class IfPrintStarted:EventArgs
    {
        public AbstractPrinter AbstPrinter { get; set; }
        public string Message { get; set; }

        public IfPrintStarted(AbstractPrinter printer, string message)
        {
            AbstPrinter = printer;
            Message = message;
        }
    }
}
