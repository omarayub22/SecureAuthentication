using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

   /* [HttpGet]
      public ActionResult<IEnumerable<AppUser>> GetUsers()
      {
          var user = _context.Users.ToList();
          return user;
      }

    [HttpGet("{Id}")]
    public ActionResult<AppUser> GetUser(int Id)
    {
    var user = _context.Users.Find(Id);
    return user;
    } */


[HttpGet]
  public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
  {
    return await _context.Users.ToListAsync();
  }
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        /*var user = await _context.Users.FindAsync(id);
        return user;*/
        //or
        return await _context.Users.FindAsync(id);

    }

}
}