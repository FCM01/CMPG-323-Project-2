using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cmpgAPI.models;
using Microsoft.AspNetCore.Authorization;
using JWTAuthentication.Authentication;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cmpgAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        private readonly ConnectedOfficeContext _context;
        public ValuesController(ConnectedOfficeContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController> Create a GET method that retrieves all devices within a specific zone (based on the zone ID that is parsed through)
        [HttpGet("/Zone/{ZoneDeviceid}")]
        public async Task<ActionResult<IEnumerable<Device>>> GetZone(Guid ZoneDeviceid)
        {
            

            if (_context.Device == null)
            {
                return NotFound();
            }
            return  await _context.Device.Where(device => device.ZoneId == ZoneDeviceid).ToListAsync();
            
        }

        //GET api/<ValuesController> /5Create a GET method that will return the number of zones that are associated to a specific category (use the device entity to join the data)
        [HttpGet("/Category/{CategoryDeviceId}")]
        [Authorize(Roles = UserRoles.Admin)]
        public async  Task<ActionResult<IEnumerable<Device>>> GetAction(Guid CategoryDeviceId)
        {
            if (_context.Device == null )
            {
                return NotFound();
            }
            return await _context.Device.Where(category => category.CategoryId == CategoryDeviceId).ToListAsync();
        }

       
    }
}
