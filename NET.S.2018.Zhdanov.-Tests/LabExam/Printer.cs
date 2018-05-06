namespace LabExam
{
    public class Printer:AbstractPrinter
    {
        #region Constructor
        public Printer(string name,string model)
        {
            Name = name;
            Model = model;
        }
        #endregion

        #region Properties
        public string Name { get; set; }

        public  string Model { get; set; }
        #endregion
       
    }
}