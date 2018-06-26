using System.Threading.Tasks;
using TibiaCharInfo.Models;

namespace TibiaCharInfo.Services
{
    interface IHighscoreService : IServiceBase<Highscore>
    {
        Task<Highscore> Get(string world, HighscoreType type);
        Task<Highscore> Get(string world, HighscoreType type, Vocation vocation);
    }
}
