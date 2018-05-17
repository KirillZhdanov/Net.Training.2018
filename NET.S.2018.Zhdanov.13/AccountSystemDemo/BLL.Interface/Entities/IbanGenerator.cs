using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;
using sinkien.IBAN4Net;


namespace BLL.Interface.Entities
{
    public  class IbanGenerator : IIbanGenerator
    {
        public string IbanGerate()
        {
            Iban iban = new IbanBuilder()
                .CountryCode(CountryCode.GetCountryCode("BY"))
                .BankCode("505")
                .AccountNumberPrefix("19")
                .Build();

            return iban.ToString();
        }
    }
}
