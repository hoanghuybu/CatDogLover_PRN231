using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Account> GetAccount()
        {
            var listAccount = new List<Account>();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    listAccount = context.Accounts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listAccount;
        }

        public Account FindAccountById(int id)
        {
            Account account = new Account();
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    account = context.Accounts.SingleOrDefault(c => c.AccountId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }

        public void SaveAccount(Account account)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateAccount(Account account)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    context.Entry<Account>(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteAccount(Account account)
        {
            try
            {
                using (var context = new CatDogLoverContext())
                {
                    var deleteAccount = context.Accounts.SingleOrDefault(c => c.AccountId == account.AccountId);
                    context.Accounts.Remove(deleteAccount);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
