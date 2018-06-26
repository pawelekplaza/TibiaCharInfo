using Newtonsoft.Json;
using System.Threading.Tasks;
using TibiaCharInfo.Models;
using TibiaCharInfo.Responses;

namespace TibiaCharInfo.Services
{
    public class HighscoreService : ServiceBase, IHighscoreService
    {
        private readonly string _baseUri = @"highscores/";
        public async Task<Highscore> Get(string world)
        {
            var response = await GetResponse($"{ _baseUri }{ world }.json");
            return JsonConvert.DeserializeObject<HighscoreResponse>(response).Highscores;
        }

        public async Task<Highscore> Get(string world, HighscoreType type)
        {
            var response = await GetResponse($"{ _baseUri }{ world }//{ type.GetProperString() }.json");
            return JsonConvert.DeserializeObject<HighscoreResponse>(response).Highscores;
        }

        public async Task<Highscore> Get(string world, HighscoreType type, Vocation vocation)
        {
            var response = await GetResponse($"{ _baseUri }{ world }//{ type.ToString() }//{ vocation.GetQueryString() }.json");
            return JsonConvert.DeserializeObject<HighscoreResponse>(response).Highscores;
        }
    }
}
