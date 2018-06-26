using System.Threading.Tasks;
using TibiaCharInfo.Models;
using TibiaCharInfo.Responses;

namespace TibiaCharInfo.Services
{
    public class CharacterService : ServiceBase, ICharacterService
    {
        private readonly string _baseUri = @"characters/";
        public async Task<Character> Get(string characterName)
        {
            var response = await GetResponse($"{ _baseUri }{ characterName.Replace(' ', '+') }.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CharacterResponse>(response).Characters;
        }
    }
}
