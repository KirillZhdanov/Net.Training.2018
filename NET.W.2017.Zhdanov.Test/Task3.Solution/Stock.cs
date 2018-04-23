using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock
    {
          
      

        public void Market()
        {
            var Info = new IfChanged();
            Random rnd = new Random();
            Info.USD = rnd.Next(20, 40);
            Info.Euro = rnd.Next(30, 50);
            IfValueIsChanged(Info.USD,Info.Euro);
           
        }
        public void IfValueIsChanged(int a, int b) => ChangedValue?.Invoke(this, new IfChanged(a, b));
        public event EventHandler<IfChanged> ChangedValue;
    }
}
