using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sites4u.Data;
using sites4u.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sites4u.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;

        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("Auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret key";
        
        }
        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null)
                return NotFound();
            return Ok(thing);

        }


        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("thing was not a good request");
        }

    }
}
