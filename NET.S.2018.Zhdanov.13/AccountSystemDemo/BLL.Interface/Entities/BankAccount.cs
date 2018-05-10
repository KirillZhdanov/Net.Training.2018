using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public abstract class BankAccount
    {
        #region Private fields

        private string iban;
        private int clientId;
        private decimal balance;
        private int bonus;

        #endregion

        #region Constructor
       
        public BankAccount(string iban, int clientId, decimal balance = 0, int bonusPoints = 0, bool isClosed = false)
        {
            Iban = iban;
            ClientId = clientId;
            Balance = balance;
            Bonus = bonusPoints;
            IsClosed = isClosed;
        }

        #endregion

        #region Properties

        public string Iban
        {
            get
            {
                return iban;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"{nameof(Iban)} cannot be null.");
                }

                iban = value;
            }
        }

      
        public int ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} cannot be lesser than one.");
                }

                clientId = value;
            }
        }

       
        public decimal Balance
        {
            get
            {
                return balance;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Balance)} is less than zero.");
                }

                balance = value;
            }
        }

      
        public int Bonus
        {
            get
            {
                return bonus;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Bonus)} is less than zero.");
                }

                bonus = value;
            }
        }

        /// <summary>
        /// Account's closed status.
        /// </summary>
        public bool IsClosed { get; private set; }

        protected abstract int AddtoBalance { get;  }
               

        protected abstract int ReduceBalance { get; }

      

        #endregion

        #region Public methods

       
        public void AddMoney(decimal amount)
        {
            if (IsClosed)
            {
                throw new InvalidOperationException($"Account is closed. All operations are unavailable.");
            }

            Balance += amount;
            Bonus += (int)((AddtoBalance * Balance) + amount);
        }

      
        public void Withdraw(decimal amount)
        {
            if (IsClosed)
            {
                throw new InvalidOperationException($"Account is closed. All operations are unavailable.");
            }

            Balance -= amount;
            Bonus -= (int)((ReduceBalance * Balance) + amount);
        }

        #endregion

        
      
    }
}
