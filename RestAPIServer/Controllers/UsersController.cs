using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPIServer.DBContext;
using RestAPIServer.Models;

namespace RestAPIServer.Controllers
{
    [ApiController]
    [EnableCors("MyAllowAllHeadersPolicy")]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public readonly UserContext _userDbContext;
        
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger,UserContext userDbContext)
        {
            _logger = logger;
            _userDbContext = userDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetAllUsers()
        {
            if (_userDbContext.UsersList == null)
            {
                return NotFound();
            }
            else
            {
                try {
                    var list = await _userDbContext.UsersList.ToListAsync();
                    return list;
                }
                catch(Exception ex)
                {
                    return NotFound();
                }
              
            }
        }


        [HttpGet("{Id}")]
        public List<string> GetByID(string Id)
        {
            if (Id != null)
                return null;
            else
                return null;
        }
    }
}
