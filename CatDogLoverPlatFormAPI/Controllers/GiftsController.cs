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
    public class GiftsController : ControllerBase
    {
       

        // GET: api/Gifts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gift>>> GetGifts()
        {
            return null;
        }

        // GET: api/Gifts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gift>> GetGift(string id)
        {
            

            return null;
        }

        // PUT: api/Gifts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGift(string id, Gift gift)
        {
           

            return null;
        }

        // POST: api/Gifts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Gift>> PostGift(Gift gift)
        {
           

            return null;
        }

        private bool GiftExists(string id)
        {
            return false;
        }
    }
}
