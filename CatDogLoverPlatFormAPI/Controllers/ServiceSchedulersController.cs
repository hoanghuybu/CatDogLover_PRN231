using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BussinessObjects;

namespace CatDogLoverPlatFormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceSchedulersController : ControllerBase
    {
        

        // GET: api/ServiceSchedulers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceScheduler>>> GetServiceSchedulers()
        {
            return null;
        }

        // GET: api/ServiceSchedulers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceScheduler>> GetServiceScheduler(string id)
        {
            

            return null;
        }

        // PUT: api/ServiceSchedulers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceScheduler(string id, ServiceScheduler serviceScheduler)
        {
            

            return null;
        }

        // POST: api/ServiceSchedulers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ServiceScheduler>> PostServiceScheduler(ServiceScheduler serviceScheduler)
        {
            

            return null;
        }

        // DELETE: api/ServiceSchedulers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceScheduler(string id)
        {
           

            return null;
        }

        private bool ServiceSchedulerExists(string id)
        {
            return false;
        }
    }
}
