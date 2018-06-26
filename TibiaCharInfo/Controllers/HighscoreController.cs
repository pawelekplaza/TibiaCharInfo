using System.Threading.Tasks;
using TibiaCharInfo.Models;
using TibiaCharInfo.Services;

namespace TibiaCharInfo.Controllers
{
    public class HighscoreController
    {
        private readonly IHighscoreService _highscoreService = ServicesStorage.Instance.GetService<IHighscoreService>();

        public async Task<Highscore> GetHighscore(string world)
        {
            return await _highscoreService.Get(world);
        }

        public async Task<Highscore> GetHighscore(string world, HighscoreType type)
        {
            return await _highscoreService.Get(world, type);
        }

        public async Task<Highscore> GetHighscore(string world, HighscoreType type, Vocation vocation)
        {
            return await _highscoreService.Get(world, type, vocation);
        }
    }
}
