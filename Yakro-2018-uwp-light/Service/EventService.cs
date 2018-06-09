using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakro_2018_uwp_light.Service
{
    public class EventService : IEventService
    {
        public IEnumerable<Model.Event> GetAll()
        {
            return new List<Model.Event> {
                new Model.Event
                {
                    Id = 1, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 2, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 3, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 4, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 5, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 6, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 7, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },new Model.Event
                {
                    Id = 8, CreatedDate = DateTime.Now, Description = "My first Event", DislikeCount=0, LikeCount=100,
                    PublishDate = DateTime.Today.Date
                },
            };
        }
    }
}
