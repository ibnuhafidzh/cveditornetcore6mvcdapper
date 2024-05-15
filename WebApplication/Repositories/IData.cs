using WebApplication.Models;

namespace WebApplication.Repositories
{
    public interface IData
    {
        Task<IEnumerable<DataModel>> Get();
        Task<DataModel> Find(String uid);
        Task<DataModel> Add(DataModel model);
        Task<DataModel> Update(DataModel model);
        Task<DataModel> Remove(DataModel model);
    }
}
