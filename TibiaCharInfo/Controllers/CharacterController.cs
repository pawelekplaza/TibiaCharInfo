using System.Threading.Tasks;
using TibiaCharInfo.Models;
using TibiaCharInfo.Services;

namespace TibiaCharInfo.Controllers
{
    public class CharacterController
    {
        private readonly ICharacterService _characterService = ServicesStorage.Instance.GetService<ICharacterService>();

        public async Task<Character> GetCharacter(string characterName)
        {
            return await _characterService.Get(characterName);
        }
    }
}
