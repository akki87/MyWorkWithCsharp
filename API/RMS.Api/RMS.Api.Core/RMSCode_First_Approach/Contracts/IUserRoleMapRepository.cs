using RMS.Api.Core.Models;

namespace RMS.Api.Core.Contracts
{
	public interface IUserRoleMapRepository
	{
		public List<UserRoleMap> GetAllUserRoleMaps();
		public Role GetUserRoleMap(int id);
		public bool AddUserRoleMap(Role role);
		public bool UpdateUserRoleMap(int id, Role role);
		public bool RemoveUserRoleMap(int id);
	}
}
