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
}