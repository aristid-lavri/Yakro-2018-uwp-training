using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakro_2018_uwp_light.Service
{
    public class SettingsService : ISettingsService
    {
        public IEnumerable<Model.Category> GetAll()
        {
            return new List<Model.Category> {
                new Model.Category
                {
                    Id = 1, CreatedDate = DateTime.Now, Name = "Sport"
                },new Model.Category
                {
                    Id = 2, CreatedDate = DateTime.Now, Name = "Potin"
                },new Model.Category
                {
                    Id = 3, CreatedDate = DateTime.Now, Name = "Socio Culturel"
                },new Model.Category
                {
                    Id = 4, CreatedDate = DateTime.Now, Name = "News"
                },new Model.Category
                {
                    Id = 5, CreatedDate = DateTime.Now, Name = "Circulation"
                },new Model.Category
                {
                    Id = 6, CreatedDate = DateTime.Now, Name = "Securité"
                },new Model.Category
                {
                    Id = 7, CreatedDate = DateTime.Now, Name = "Politique"
                },
            };
        }
    }
}
