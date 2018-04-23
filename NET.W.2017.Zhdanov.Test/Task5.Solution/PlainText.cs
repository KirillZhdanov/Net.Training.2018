namespace Task5
{
    public class PlainText : DocumentPart
    {
        public override string Convert(IConverter converter)
        {
            return converter.Convert(this);
        }
    }
}
