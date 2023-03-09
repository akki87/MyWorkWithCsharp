using RMS.Api.Core.Contracts;
using RMS.Api.Core.DTO;
using RMS.Api.Core.Models;
using RMS.Api.Infrastructure.Context;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace RMS.Api.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly RMSContext _context;

        public UserRepository(RMSContext context)
        {
            _context = context;
        }
        public int UsersCount { get; }

        public async Task<bool> UpdateUser(int id, UserDto User)
        {
            User usertoBeUpdated = _context.Users.Find(id);
            usertoBeUpdated.UserId=usertoBeUpdated.UserId;
            usertoBeUpdated.Name=User.Name;
            usertoBeUpdated.Status=usertoBeUpdated.Status;
            usertoBeUpdated.CreatedBy=usertoBeUpdated.CreatedBy;
            usertoBeUpdated.CreatedDate=usertoBeUpdated.CreatedDate;
            usertoBeUpdated.ModifiedDate = DateTime.Now;
            usertoBeUpdated.ModifiedBy=usertoBeUpdated.ModifiedBy;
            usertoBeUpdated.Phone=User.PhoneNumber;
            _context.Users.Update(usertoBeUpdated);
            _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveUser(int id)
        {
            User user = _context.Users.FirstOrDefault(_ => _.UserId==id);
            _context.Users.Remove(user);
            _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> AddUser(UserDto customer)
        {
            User user = new User();
            user.Name= customer.Name;
            user.Phone= customer.PhoneNumber;
            user.Uname= customer.UserName;
            user.Password= customer.Password;
            user.CreatedBy=220222;
            user.CreatedDate= DateTime.Now;
            user.ModifiedBy=220222;
            user.ModifiedDate= DateTime.Now;
            user.Status=true;
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
        public async Task<User> GetUserId(int id)
        {
            return _context.Users.Find(id);
        }
        public async Task<List<User>> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public async Task<User> GetUserByMobileNumber(string mobileNumber)
        {
            return _context.Users.FirstOrDefault(_ => _.Phone==mobileNumber);
        }
        public async Task<List<User>> GetAllUsers(int? page = 1,
           int? pageSize = 10,
        string? sortColumn = null,
           string sortOrder = "Asc",
        string? includeProperties = null,
           params Expression<Func<User, bool>>[] filter)
        {
            IQueryable<User> tabledata = _context.Users;
            foreach (var item in filter)
            {
                if (filter != null)
                {
                    tabledata = tabledata.Where(item);
                }
            }
            //tabledata = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            //.Aggregate(tabledata, (current, includeProperty) => current.Include(includeProperty));

            if (!string.IsNullOrEmpty(sortColumn))
            {
                if (!string.IsNullOrEmpty(sortOrder) && sortOrder.ToLower().Contains("Asc".ToLower()))
                {
                    tabledata = tabledata.OrderBy(sortColumn);
                }
                else
                {
                    tabledata = tabledata.OrderBy(sortColumn).Reverse();
                }
            }
            if (tabledata.Count() < pageSize) page = 1;
            if (page != null && pageSize != null)
                tabledata = tabledata
                    .Skip((page.Value - 1) * pageSize.Value)
                    .Take(pageSize.Value);

            return tabledata.ToList();
        }
    }
}
