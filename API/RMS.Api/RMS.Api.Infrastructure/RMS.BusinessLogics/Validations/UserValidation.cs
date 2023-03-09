using Couchbase.Management.Users;
using Microsoft.EntityFrameworkCore;
using RMS.Api.Infrastructure.Data.Context;
using User = RMS.Api.Core.Models.User;

namespace RMS.Api.Infrastructure.Validations
{
	public  class UserValidation //: IUserValidation 
	{
		public  static RMSContext Context;

		public UserValidation(RMSContext context)
		{
			Context = context;
		}

		public  void Validate(string username, string password,string methodName)
        {
			List<User> users = Context.Users.ToList();
			User user = users.FirstOrDefault(x => x.Uname==username);
			if (user != null)
			{
				if (user.Password == password)
				{
					OnUserPrivilegeValidation(user.UserId, methodName);
				}
				else
				{
					throw new InvalidPasswordException("Incorrect password");
				}
			}
			else
			{
				throw new UserNotFoundException(username);
			}
		}
        public  bool OnUserPrivilegeValidation(int id,string method)
        {
			var UserRole = from c in Context.Users.ToList()
						   join uroles in Context.UserRoleMaps.ToList() on c.UserId equals uroles.UserId
						   join roles in Context.Roles.ToList() on uroles.RoleId equals roles.RoleId
						   where c.UserId == id
						   select roles.RoleName;
			var UserPrivileges = (from pm in Context.RolePrivilegeMaps.ToList()
								  join p in Context.Privileges.ToList() on pm.PrivilegeId equals p.PrivilegeId
								  join roles in Context.Roles.ToList() on pm.RoleId equals roles.RoleId
								  where UserRole.ToList().Contains(roles.RoleName)
								  select p.PrivilegeName).ToList();
			if (UserPrivileges.Count!=0)
			{
				if (UserPrivileges.Contains(method))
				{
					return true;
				}
				else
				{
					throw new NoAuthorizationFoundException("No authorization registered");
				}
			}
			else
			{
				throw new NoPrivilegesFoundException("No privileges set");
			}
		}
    }
}