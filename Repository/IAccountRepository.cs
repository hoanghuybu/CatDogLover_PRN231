using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IAccountRepository
    {
        public void DeleteAccount(Account account);
        public void UpdateAccount(Account account);
        public void SaveAccount(Account account);
        public Account FindAccountById(int id);
        public List<Account> GetAccount();
    }
}
