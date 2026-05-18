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

    }
}
