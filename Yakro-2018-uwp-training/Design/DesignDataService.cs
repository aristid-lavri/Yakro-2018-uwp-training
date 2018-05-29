using System.Threading.Tasks;
using Yakro_2018_uwp_training.Model;

namespace Yakro_2018_uwp_training.Design
{
    public class DesignDataService : IDataService
    {
        public Task<DataItem> GetData()
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            return Task.FromResult(item);
        }
    }
}