using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class GoldAccount : BankAccount
    {
        public GoldAccount(string iban, int ownersId, decimal balance = 0, int bonusPoints = 0, bool isClosed = false) : base(iban, ownersId, balance, bonusPoints, isClosed)
        {
        }

        protected override int AddtoBalance =>5;

        protected override int ReduceBalance => 3;
    }
}
