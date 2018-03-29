using System;
using System.Collections.Generic;

namespace Task2Logic
{
    /// <summary>
    /// Account's collection
    /// </summary>
    public class AccountService :Bank
    {
        
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

        public AccountService(string surname, string name, double balance, double bonus, int id,int grade,bool isClosed)
            :base( surname,  name ,  balance , bonus ,  id, grade,isClosed)
        {
           
            switch (grade)
            {
                case 1:
                    n = 3;
                    break;
                case 2:
                    n = 5;
                    break;
                case 3:
                    n = 7;
                    break;
                case 4:
                    n = 9;
                    break;
                default:
                    n = 3;
                    break;
            }
                
        }
        private int n;
     

        #region Properties

        /// <summary>
        /// account's collection
        /// </summary>
        public List<Bank> ListOfClients { get; private set; }
        /// <summary>
        /// Addmoney coeff
        /// </summary>
        protected override int AddtoBalance => n;
        /// <summary>
        /// Reduce money coeff
        /// </summary>
        protected override int PersonalReduce => n-1;

       

        #endregion

        #region Public Methods

        /// <summary>
        /// Add account to collection and storage
        /// </summary>
        /// <param name="account"></param>
        public void AddAccount(Bank account)
        {
           

            AddItem(account);
        }

        /// <summary>
        /// Remove account from collection and storage
        /// </summary>
        /// <param name="account"></param>
        public void RemoveAccount(Bank account)
        {
          
            RemoveItem(account);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public bool FindById(Bank Id)
        {
            return ListOfClients.Contains(Id);
        }


       
        #endregion

        #region Private Methods

       

        /// <summary>
        /// Add account to collection 
        /// </summary>
        /// <param name="account"></param>
        private void AddItem(Bank account)
        {
            ListOfClients.Add(account);
           
        }

        /// <summary>
        /// Remove account from collection 
        /// </summary>
        /// <param name="client"></param>
        private void RemoveItem(Bank client)
        {
            ListOfClients.Remove(client);
          
        }



        #endregion
       
    }
}