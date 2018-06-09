using Yakro_2018_uwp_light.Model;

namespace Yakro_2018_uwp_light.Service
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}