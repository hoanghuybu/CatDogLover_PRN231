using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using DataAccess;

namespace Repository
{
    public class RoleRepository : IRoleRepository
    {
        public void DeleteRole(Role role) => RoleDAO.Instance.DeleteRole(role);

        public Role FindRoleById(int id) => RoleDAO.Instance.FindRoleById(id);

        public List<Role> GetRole() => RoleDAO.Instance.GetRole();

        public void SaveRole(Role role) => RoleDAO.Instance.SaveRole(role);

        public void UpdateRole(Role role) => RoleDAO.Instance.UpdateRole(role);
    }
}
