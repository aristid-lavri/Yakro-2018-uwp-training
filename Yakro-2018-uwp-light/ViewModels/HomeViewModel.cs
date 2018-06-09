using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yakro_2018_uwp_light.Service;

namespace Yakro_2018_uwp_light.ViewModels
{
    public class HomeViewModel
    {
        private IEventService _eventService;
        private Model.Event selectedEvent;


        public HomeViewModel()
        {
            _eventService = new EventService();
            Events = new ObservableCollection<Model.Event>();
        }

        public void Load()
        {
            var events = _eventService.GetAll();
            foreach (var item in events)
            {
                Events.Add(item);
            }
        }


        public Model.Event SelectedEvent
        {
            get { return selectedEvent; }
            set { selectedEvent = value; }
        }

        public ObservableCollection<Model.Event> Events { get; set; }
    }
}
