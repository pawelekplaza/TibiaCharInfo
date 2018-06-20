using System.Threading.Tasks;

namespace TibiaCharInfo.Services
{
    interface IServiceBase<T>
    {
        Task<T> Get(string uri);
    }
}
