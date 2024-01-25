using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_project.Data;
using net_project.Models;

namespace net_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TemplateContext _context;

        public UsersController(TemplateContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }
    }
}
