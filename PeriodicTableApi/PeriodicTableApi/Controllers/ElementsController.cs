using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Repositories;

namespace PeriodicTableApi.Controllers
{
    [Route ( "api/elements" )]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public ElementsController ( RepositoryContext context )
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetElements ( )
        {
            try
            {
                var elements = _context.Elements
                .Include(e => e.Image)
                .AsNoTracking()
                .ToList();

                return Ok ( elements );
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( $"Error in GetElements: {ex.Message}" );
                return StatusCode ( 500, "An error occurred while retrieving elements." );
            }
        }

        [HttpGet ( "{atom:int}" )]
        public IActionResult GetElementByAtomNumber ( int atom )
        {
            try
            {
                var element = _context.Elements
                .Include(e => e.Image)
                .AsNoTracking()
                .FirstOrDefault(e => e.Number == atom);

                if ( element == null )
                {
                    return NotFound ( $"Element with Atom Number {atom} not found." );
                }

                return Ok ( element );
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( $"Error in GetElementByAtomNumber: {ex.Message}" );
                return StatusCode ( 500, $"An error occurred while retrieving element {atom}." );
            }
        }
    }
}
