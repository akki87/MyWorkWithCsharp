using RMS.Api.Core.DTO;
using RMS.Api.Core.Models;
using System.Linq.Expressions;

namespace RMS.Api.Core.Contracts
{
	public interface IUserRepository
	{
        public int UsersCount { get; }

        public Task<bool> UpdateUser(int id, UserDto User);
        public Task<bool> RemoveUser(int id);
        public Task<bool> AddUser(UserDto user);
        public Task<User> GetUserId(int id);
        public Task<List<User>> GetAllUsers();
        public Task<User> GetUserByMobileNumber(string mobileNumber);
        public Task<List<User>> GetAllUsers(int? page = 1,
           int? pageSize = 10,
        string? sortColumn = null,
           string sortOrder = "Asc",
        string? includeProperties = null,
           params Expression<Func<User, bool>>[] filter);
    }
}
