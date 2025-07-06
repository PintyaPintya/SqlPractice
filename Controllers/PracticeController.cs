using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SqlQueryPractice.Models;

namespace SqlQueryPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        private readonly SqlPracticeContext _context;

        public PracticeController(SqlPracticeContext context)
        {
            _context = context;
        }

        [HttpGet("Select")]
        public async Task<ActionResult> Select()
        {
            var result = await _context.Students.ToListAsync();

            return Ok(result);
        }
    }
}
