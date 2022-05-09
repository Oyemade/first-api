using System.Collections.Generic;
using System.Threading.Tasks;
using first_api.Dtos.Character;
using first_api.Models;

namespace first_api.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}