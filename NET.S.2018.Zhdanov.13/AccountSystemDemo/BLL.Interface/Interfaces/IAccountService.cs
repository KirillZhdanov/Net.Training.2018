using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;

namespace BLL.Interface.Interfaces
{
    public interface IAccountService
    {
       
        void OpenAccount(BankClient client, decimal balance);

       
        void CloseAccount(string iban);

       
        void Deposit(string iban, decimal amount);

       
        void Withdraw(string iban, decimal amount);

       

       
    }
}
