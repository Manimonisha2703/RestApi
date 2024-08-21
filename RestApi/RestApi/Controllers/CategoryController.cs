using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Domain.Model;
using RestApi.Persistence;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly dbcontext _database;

        public CategoryController(dbcontext database) { 

            _database = database;
        }

        [HttpPost]
        public async Task<IActionResult> createProduct([FromBody] Category category)
        {
            _database.Add(category);
            await _database.SaveChangesAsync();
            return Ok(category);
        }

        [HttpGet]

        public async Task<IActionResult> getProduct()
        {
            List<Category> category = new List<Category>();
            category = _database.Category?.ToList();
            return Ok(category);
        }

        [HttpPut]

        public async Task<IActionResult> updateProduct(int id, [FromBody] Category category)
        {
            var existing = await _database.Category.FindAsync(id);
            existing.Type = category.Type;
            await _database.SaveChangesAsync();
            return Ok(category);
        }

        [HttpDelete]

        public async Task<IActionResult> deleteProduct(int id)
        {
            var ExistingCategory = await _database.Category.FindAsync(id);
            _database.Category.Remove(ExistingCategory);
            await _database.SaveChangesAsync();
            return Ok();
        }

    }
}
