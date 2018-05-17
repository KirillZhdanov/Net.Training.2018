using System.Collections.Generic;
using DAL.Interface.DTO;

namespace DAL.Interface.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// ADD bank account
        /// </summary>
        /// <param name="bankAccount"></param>
        void Add(BankAccountDto bankAccount);

        /// <summary>
        ///Update bank account 
        /// </summary>
        /// <param name="bankAccount"></param>
        void Update(BankAccountDto bankAccount);

        /// <summary>
        /// Get bank accounts
        /// </summary>
        /// <returns></returns>
        IEnumerable<BankAccountDto> GetBankAccounts();
        /// <summary>
        /// Get bank accounts according to their IBAN
        /// </summary>
        /// <param name="iban"></param>
        /// <returns></returns>
        BankAccountDto GetBankAccountByIban(string iban);

    }
}
