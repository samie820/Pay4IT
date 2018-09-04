using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Data;

namespace project.Features.Users
{
    [Route("api/[controller]") ]
    public class UsersController: Controller {
        private readonly EcommerceContext _db;
        public UsersController(EcommerceContext db) {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Get(){
            return Ok(await _db.Users.ToListAsync());
        }
    }

}