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
       /// <summary>
       /// 
       /// </summary>
       /// <param name="client"></param>
       /// <param name="balance"></param>
        string OpenAccount(int clientsId, decimal balance, int bonusPoints, bool isClosed, BankAccountType accountType);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iban"></param>
       
        void CloseAccount(string iban);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iban"></param>
        /// <param name="amount"></param>
       
        void Deposit(string iban, decimal amount);

       /// <summary>
       /// 
       /// </summary>
       /// <param name="iban"></param>
       /// <param name="amount"></param>
        void Withdraw(string iban, decimal amount);

        
        IEnumerable<BankAccount> GetBankAccounts();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iban"></param>
        /// <returns></returns>
        BankAccount GetBankAccountByIban(string iban);



    }
}
