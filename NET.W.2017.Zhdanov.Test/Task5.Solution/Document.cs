using System;
using System.Collections.Generic;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(IConverter converter)
        {
            string result = string.Empty;

            foreach (var part in parts)
            {
                result += part.Convert(converter);
            }
            Console.WriteLine();
            return result;
        }

    }
}
