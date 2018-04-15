using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estore.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace estore.API.Controllers
{
    [Route("api/[controller]")]
    public class BrandsController : Controller
    {
        private readonly EstoreDBContext _context;
        public BrandsController(EstoreDBContext context)
        {
            _context = context;
        }
        // GET api/brands
        [HttpGet]
        public async Task<IActionResult> getBrands()
        {
            var brands = await _context.Brands.ToListAsync();

            return Ok(brands);
        }

        // GET api/brands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var brand = await _context.Brands.FirstOrDefaultAsync(b => b.Id == id);

            return Ok(brand);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
