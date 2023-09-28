using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public void DeleteAccount(Account account) => AccountDAO.Instance.DeleteAccount(account);       

        public Account FindAccountById(int id) => AccountDAO.Instance.FindAccountById(id);

        public List<Account> GetAccount() => AccountDAO.Instance.GetAccount();

        public void SaveAccount(Account account) => AccountDAO.Instance.SaveAccount(account);

        

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);

        

        
    }
}
