using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class PlatinumAccount : BankAccount
    {
        public PlatinumAccount(string iban, int ownersId, decimal balance = 0, int bonusPoints = 0, bool isClosed = false) : base(iban, ownersId, balance, bonusPoints, isClosed)
        {
        }

        protected override int AddtoBalance => 9;

        protected override int ReduceBalance => 2  ;
    }
}
