using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetWebApi.Data;
using dotnetWebApi.Models;

namespace dotnetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamePlayerController : Controller
    {
        private readonly ApplicationDBContext _db;
        public GamePlayerController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<GamePlayer>> GetAllGamePlayers()
        {
            return await _db.GamePlayers.ToListAsync();
        }
    }
}