namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override string Convert(IConverter converter)
        {
            return converter.Convert(this);
        }
    }
}