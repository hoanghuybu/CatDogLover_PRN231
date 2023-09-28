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
    public class ReactsController : ControllerBase
    {
        

        // GET: api/Reacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<React>>> GetReacts()
        {
            return null;
        }

        // GET: api/Reacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<React>> GetReact(int id)
        {
            

            return null;
        }

        // PUT: api/Reacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReact(int id, React react)
        {
           

            return null;
        }

        // POST: api/Reacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<React>> PostReact(React react)
        {
            
            return null;
        }

        // DELETE: api/Reacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReact(int id)
        {
            

            return null;
        }

        private bool ReactExists(int id)
        {
            return false;
        }
    }
}
