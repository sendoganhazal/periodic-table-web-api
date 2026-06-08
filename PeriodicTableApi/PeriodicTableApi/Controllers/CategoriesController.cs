using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Repositories;

namespace PeriodicTableApi.Controllers
{
    [Route ( "api/categories" )]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public readonly RepositoryContext _context;

        public CategoriesController ( RepositoryContext context )
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategories ( )
        {
            try
            {
                var categories = _context.Elements
                .AsNoTracking()
                .Where(e => !string.IsNullOrEmpty(e.Category))
                .Select(e => e.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

                return Ok ( categories );
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( $"Error in GetCategories: {ex.Message}" );
                return StatusCode ( 500, "An error occurred while retrieving categories." );
            }
        }
    }
}
