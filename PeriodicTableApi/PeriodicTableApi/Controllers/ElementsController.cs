using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTableApi.Repositories;

namespace PeriodicTableApi.Controllers
{
    [Route ( "api/[controller]" )]
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
                var elements = _context.Elements.Include(e => e.Image).ToList();
                return Ok ( elements );
            }
            catch ( Exception ex )
            {

                throw new Exception ( ex.Message );
            }

        }

        [HttpGet ( "{atom:int}" )]
        public IActionResult GetElementByAtomNumber ( int atom )
        {
            try
            {
                var element = _context.Elements.Include(e => e.Image).FirstOrDefault ( e => e.Number == atom );
                if ( element == null )
                {
                    return NotFound ( $"Element with Atom Number {atom} not found." );
                }
                return Ok ( element );
            }
            catch ( Exception ex )
            {
                throw new Exception ( ex.Message );
            }
        }
        [HttpGet ( "categories" )]
        public IActionResult GetCategories ( )
        {
            try
            {
                var categories = _context.Elements
                    .Where(e => !string.IsNullOrEmpty(e.Category))
                    .Select(e => e.Category)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                return Ok ( categories );
            }
            catch ( Exception ex )
            {

                throw new Exception ( ex.Message );
            }
        }
        [HttpGet ( "category/{category}" )]
        public IActionResult GetElementsByCategory ( string category )
        {
            try
            {
                var elements = _context.Elements
                    .Include(e => e.Image)
                    .Where(e => e.Category.ToLower() == category.ToLower())
                    .ToList();

                return Ok ( elements );
            }
            catch ( Exception ex )
            {

                throw new Exception ( ex.Message );
            }
        }
    }
}
