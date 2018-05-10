using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class BankAccountDto
    {
       
        public string AccountType { get; set; }
                
        public string Iban { get; set; }
                
        public int ClientId { get; set; }

        public decimal Balance { get; set; }

        
        public int BonusPoints { get; set; }

        
        public bool IsClosed { get; set; }

        public BankAccountDto(string accountType, string iban, int clientId, decimal balance, int bonusPoints, bool isClosed)
        {
            AccountType = accountType;
            Iban = iban;
            ClientId = clientId;
            Balance = balance;
            BonusPoints = bonusPoints;
            IsClosed = isClosed;
        }
    }
}
