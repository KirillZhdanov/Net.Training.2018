namespace Task5
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

      

        public override string Convert(IConverter converter)
        {
            return converter.Convert(this);
        }

    }
}
