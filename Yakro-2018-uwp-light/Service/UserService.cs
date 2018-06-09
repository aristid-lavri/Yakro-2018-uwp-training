using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yakro_2018_uwp_light.Model;

namespace Yakro_2018_uwp_light.Service
{
    public class UserService : IUserService
    {
        public User Login(string username, string password)
        {
            return new User {Id = 1, Email = "lavri.alain@outlook.com", UserName = "aristid_lavri" };
        }
    }
}
