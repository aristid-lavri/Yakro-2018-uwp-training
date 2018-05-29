using System.Threading.Tasks;

namespace Yakro_2018_uwp_training.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}