namespace LabExam
{
    internal  class CanonPrinter:AbstractPrinter
    {
        public CanonPrinter()
        {
            Name = "Canon";
            Model = "123x";
        }
              

        public  string Name { get; set; }

        public  string Model { get; set; }
    }
}