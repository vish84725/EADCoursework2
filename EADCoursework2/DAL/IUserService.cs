using EADCoursework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<int> RegisterUser(User user);
        Task<User> LoginUser(User user);
    }
}
