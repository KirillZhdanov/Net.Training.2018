namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);
            var html = new Task5.ToHtmlConverter();
            var latex = new Task5.LaTexConverter();
            var plain = new Task5.ToPlainConverter();
            Console.WriteLine(document.Convert(html));

           Console.WriteLine(document.Convert(plain));

            Console.WriteLine(document.Convert(latex));
        }
    }
}
