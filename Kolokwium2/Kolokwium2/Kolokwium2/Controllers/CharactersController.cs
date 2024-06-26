﻿using Kolokwium2.DTO;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CharactersController (IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacter(int characterId)
    {
        
        var characters = await _dbService.GetCharacterData(characterId);
        return Ok(characters.Select(e => new GetCharacterDTO()
        {
            FirstName = e.FirstName,
            LastName = e.LastName,
            currentWeight = e.CurrentWei,
            maxWeight = e.MaxWeight
        }).ToList()
        );
    }
}