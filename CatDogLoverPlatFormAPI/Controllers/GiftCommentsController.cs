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
    public class GiftCommentsController : ControllerBase
    {
        

        // GET: api/GiftComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GiftComment>>> GetGiftComments()
        {
            return null;
        }

        // GET: api/GiftComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GiftComment>> GetGiftComment(int id)
        {
           

            return null;
        }

        // PUT: api/GiftComments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGiftComment(int id, GiftComment giftComment)
        {
            

            return null;
        }

        // POST: api/GiftComments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GiftComment>> PostGiftComment(GiftComment giftComment)
        {
            
            return null;
        }

        // DELETE: api/GiftComments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGiftComment(int id)
        {
            

            return null;
        }

        private bool GiftCommentExists(int id)
        {
            return false;
        }
    }
}
