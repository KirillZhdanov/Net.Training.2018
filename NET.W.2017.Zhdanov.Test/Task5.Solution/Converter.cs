using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LaTexConverter : IConverter
    {
        public string Convert(BoldText boldText)
        {
            if (boldText == null)
                throw new ArgumentNullException("Bold can't be null");
            return "\\textbf{" + boldText.Text + "}";
        }

        public string Convert(Hyperlink hyperlink)
        {
            if (hyperlink == null)
                throw new ArgumentNullException("can't be null");
            return "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";
        }

        public string Convert(PlainText plainText)
        {
            if (plainText == null)
                throw new ArgumentNullException(" can't be null");
            return plainText.Text;
        }
    }
    public class ToHtmlConverter : IConverter
    {
        public string Convert(BoldText boldText)
        {
            if (boldText == null)
                throw new ArgumentNullException("Bold can't be null");
            return "<b>" + boldText.Text + "</b>";
        }

        public string Convert(Hyperlink hyperlink)
        {
            if (hyperlink == null)
                throw new ArgumentNullException("can't be null");
            return "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
        }

        public string Convert(PlainText plainText)
        {
            if (plainText == null)
                throw new ArgumentNullException(" can't be null");
            return plainText.Text;
        }
    }
    public class ToPlainConverter : IConverter
    {
        public string Convert(BoldText boldText)
        {
            if (boldText == null)
                throw new ArgumentNullException("Bold can't be null");
            return "**" + boldText.Text + "**";

        }

        public string Convert(Hyperlink hyperlink)
        {
            if (hyperlink == null)
                throw new ArgumentNullException("can't be null");
            return  hyperlink.Text + " [" + hyperlink.Url + "]";
        }

        public string Convert(PlainText plainText)
        {
            if (plainText == null)
                throw new ArgumentNullException(" can't be null");
            return plainText.Text;
        }
    }
}
