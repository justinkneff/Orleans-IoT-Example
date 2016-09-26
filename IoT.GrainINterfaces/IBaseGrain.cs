using System.Threading.Tasks;
using Orleans;
using IoT.Models;

namespace IoT.GrainINterfaces
{
    public interface IBaseGrain<TModel> : IGrainWithGuidKey
        where TModel : BaseModel
    {
        Task<TModel> Get();
        Task Set(TModel grain);
        Task Delete();
    }
}
