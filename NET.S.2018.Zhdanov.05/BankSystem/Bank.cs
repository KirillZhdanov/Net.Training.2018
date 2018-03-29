using System;

namespace Task2Logic
{
    /// <summary>
    /// Bank class
    /// </summary>
    public class Bank
    {
        #region Constructor

     /// <summary>
     /// 
     /// </summary>
     /// <param name="surname"></param>
     /// <param name="name"></param>
     /// <param name="balance"></param>
     /// <param name="bonus"></param>
     /// <param name="id"></param>
     /// <param name="grade"></param>
     /// <param name="isClosed"></param>
        public Bank(string surname, string name, double balance, double bonus,int id,int grade,bool isClosed)
        {
            Surname = surname;
            Name = name;
            Balance = balance;
            Bonus = bonus;
            ID = id;
            Grade = grade;
           IsClosed= isClosed;

        }
        

        #endregion

        #region Properties

       /// <summary>
       /// Lastname
       /// </summary>
        public string Surname { get; private set; }
       /// <summary>
       /// Firstname
       /// </summary>
        public string Name { get; private set; }
       /// <summary>
       /// Balace situation
       /// </summary>
        public double Balance { get; private set; }
       /// <summary>
       /// Points
       /// </summary>
        public double Bonus { get; private set; }
      /// <summary>
      /// Id of client
      /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int Grade { get; private set; }
        /// <summary>
        /// Add to Balance coeff
        /// </summary>
       protected virtual int AddtoBalance { get; }
        /// <summary>
        /// Reduce coeff
        /// </summary>

        protected virtual int PersonalReduce { get; }
        /// <summary>
        /// Checker
        /// </summary>
        public bool IsClosed { get; private set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Closes account.
        /// </summary>
        public void Close()
        {
            IsClosed = true;
        }

        /// <summary>
        /// 3% Cashback
        /// </summary>
        /// <param name="spent"></param>
        public void CashBackBalance(double spent)
        {
            Balance -= spent;
            Bonus += spent / 33;
        }

        /// <summary>
        /// Addmoneyto the account.
        /// </summary>
        /// <param name="spent">Amount.</param>
        public void AddMoney(double spent)
        {
            if (IsClosed)
            {
                throw new ArgumentException($"Account is closed. All operations are unavailable.");
            }

            Balance += spent;
            Bonus += (AddtoBalance * Balance) + spent;
        }

        /// <summary>
        /// Reduce money from the account.
        /// </summary>
        /// <param name="spent">Amount.</param>
        public void ReduceBalance(double spent)
        {
            if (IsClosed)
            {
                throw new ArgumentException($"Account is closed. All operations are unavailable.");
            }
            Balance -= spent;
            Bonus -= (PersonalReduce * Balance) + spent;
        }
        #endregion
        
    }
}
