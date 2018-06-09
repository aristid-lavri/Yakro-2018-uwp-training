using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yakro_2018_uwp_light.Model;
using Yakro_2018_uwp_light.Service;

namespace Yakro_2018_uwp_light.ViewModels
{
    public class LoginViewModel
    {
        private IUserService _userService;

        public LoginViewModel()
        {
            _userService = new UserService();
        }

        public User Login(string userName, string password)
        {
            var connectedUser = _userService.Login(userName, password);

            return connectedUser;
        }
    }
}
