using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repository
{
    public interface IRoleRepository
    {
        public void DeleteRole(Role role);
        public void UpdateRole(Role role);
        public void SaveRole(Role role);
        public Role FindRoleById(int id);
        public List<Role> GetRole();
    }
}
