using System;

namespace LabExam
{/// <summary>
/// Event if print is ended
/// </summary>
    public class IfPrinted:EventArgs
    {
        public AbstractPrinter AbstPrinter { get; set; }
        public string Message { get; set; }

        public IfPrinted(AbstractPrinter printer, string message)
        {
            AbstPrinter = printer;
            Message = message;
        }
    }
}
