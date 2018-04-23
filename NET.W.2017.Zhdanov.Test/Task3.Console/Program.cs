using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var broker = new Broker("Broker", stock);
            var bank = new Bank("bank", stock);
            stock.Market();
        }
    }
}
