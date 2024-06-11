using Kolokwium2.Models;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BackpacksController : ControllerBase
{
    private readonly IDbService _dbService;
    public BackpacksController (IDbService dbService)
    {
        _dbService = dbService;
    }
    [HttpPost("{characterId}/backpacks")]
    public async Task<IActionResult> AddNewBackpack(int characterId, [FromBody] List<Backpack> backpacks)
    {
        foreach (var item in backpacks)
        {
            if (!await _dbService.DoesItemExist(item.ItemId))
            {
                return NotFound($"Item - {item.ItemId} doesn't exist");
            }   
        }

        //var character = _dbService.GetCharacterData();
        //if((character.MaxWei - character.CurrentWeight) > 
        return Ok();
    }
}