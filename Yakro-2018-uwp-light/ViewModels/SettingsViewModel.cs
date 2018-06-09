using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yakro_2018_uwp_light.Service;

namespace Yakro_2018_uwp_light.ViewModels
{
    class SettingsViewModel
    {
        private ISettingsService _settingsService;

        public SettingsViewModel()
        {
            _settingsService = new SettingsService();
            Categories = new ObservableCollection<Model.Category>();
        }

        public void Load()
        {
            var events = _settingsService.GetAll();
            foreach (var item in events)
            {
                Categories.Add(item);
            }
        }

        public ObservableCollection<Model.Category> Categories { get; set; }
    }
}
