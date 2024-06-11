using Kolokwium2.Models;

namespace Kolokwium2.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetCharacterData(int characterId);
    Task<bool> DoesItemExist(int idItem);
}