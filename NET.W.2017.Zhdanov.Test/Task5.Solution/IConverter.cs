using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{

    public interface IConverter
    {
        string Convert(BoldText boldText);
        string Convert(Hyperlink hyperlink);
        string Convert(PlainText plainText);
    }
}
