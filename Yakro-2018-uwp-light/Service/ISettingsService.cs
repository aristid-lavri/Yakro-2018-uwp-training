using System.Collections.Generic;
using Yakro_2018_uwp_light.Model;

namespace Yakro_2018_uwp_light.Service
{
    public interface ISettingsService
    {
        IEnumerable<Category> GetAll();
    }
}