using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Broker 
    {

        private Stock stock;
        public string Name { get; set; }

        public Broker(string name,Stock stock)
        {
            this.Name = name;
            this.stock = stock;

            stock.ChangedValue += Update;
        }

        public void Update(object info,IfChanged ifChanged)
        {
           

            if (ifChanged.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, ifChanged.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, ifChanged.USD);
        }

        public void StopTrade()
        {
            stock.ChangedValue -= Update;
            stock = null;
        }
    }
}
