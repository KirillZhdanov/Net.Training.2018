using System;
using System.Collections.Generic;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using DAL.Interface.Interfaces;
using BLL.Mappers;
using DAL.Interface.DTO;

namespace BLL.ServiceImplementation
{
    public class AccountService : IAccountService
    {
        #region Fields
        public IIbanGenerator Generator { get; private set; }
        
        public IRepository Repository { get; private set; }
        #endregion
        #region Constructor

        public AccountService(IRepository repository,IIbanGenerator generator)
        {
            Generator = generator;
            Repository = repository;

        }
        #endregion
        #region Implemented Interfaces
        public void CloseAccount(string iban)
        {
            throw new NotImplementedException();
        }

        public void Deposit(string iban, decimal amount)
        {
            throw new NotImplementedException();
        }

        
        public void Withdraw(string iban, decimal amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccount> GetBankAccounts()
        {
            throw new Exception();   
        }

        public BankAccount GetBankAccountByIban(string iban)
        {

            return Repository.GetBankAccountByIban(iban)?.ToBankAccount();
        }

        public string OpenAccount(int clientsId, decimal balance, int bonusPoints, bool isClosed, BankAccountType accountType)
        {
            IbanGenerator iban = new IbanGenerator();
            string accountIban= iban.IbanGerate();

            var account = CreateAccount(accountIban, clientsId, balance, bonusPoints, isClosed, accountType);

            Repository.Add(account.ToBankAccountDto());

            return accountIban;


        }
        #endregion
        private static BankAccount CreateAccount(string iban, int clientsId, decimal balance, int bonusPoints, bool isClosed, BankAccountType accountType)
        {
            switch (accountType)
            {
                case BankAccountType.Gold:
                    return new GoldAccount(iban, clientsId, balance, bonusPoints, isClosed);
                case BankAccountType.Platinum:
                    return new PlatinumAccount(iban, clientsId, balance, bonusPoints, isClosed);
                default:
                    return new BaseAccount(iban, clientsId, balance, bonusPoints, isClosed);
            }
        }
    }
}
