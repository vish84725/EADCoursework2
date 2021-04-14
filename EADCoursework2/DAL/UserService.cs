using EADCoursework2.Models;
using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.DAL
{
    public class UserService : IUserService
    {
        private const String BASEURL = "https://localhost:44314/";
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var users = await MyWalletAPI<List<User>>.Get($"{BASEURL}api/user");
                return users;
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}
