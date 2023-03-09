using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	internal interface IRolesRepository
	{
		public List<Role> GetAllRoles();
		public Role GetRole(int id);
		public bool AddRole(Role role);
		public bool UpdateRole(int id, Role role);
		public bool RemoveRole(int id);
	}
}
