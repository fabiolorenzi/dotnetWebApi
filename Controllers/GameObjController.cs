using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetWebApi.Data;
using dotnetWebApi.Models;

namespace dotnetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameObjController : Controller
    {
        private readonly ApplicationDBContext _db;
        public GameObjController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<GameObj>> GetAllGamesObj()
        {
            return await _db.GamesObj.ToListAsync();
        }
    }
}