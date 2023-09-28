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
    public class ReactTypesController : ControllerBase
    {
        
        // GET: api/ReactTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReactType>>> GetReactTypes()
        {
            return null;
        }

        // GET: api/ReactTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReactType>> GetReactType(int id)
        {
            
            return null;
        }

        // PUT: api/ReactTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReactType(int id, ReactType reactType)
        {
            
            return NoContent();
        }

        // POST: api/ReactTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReactType>> PostReactType(ReactType reactType)
        {
            

            return null;
        }

        // DELETE: api/ReactTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReactType(int id)
        {
            

            return null;
        }

        private bool ReactTypeExists(int id)
        {
            return false;
        }
    }
}
