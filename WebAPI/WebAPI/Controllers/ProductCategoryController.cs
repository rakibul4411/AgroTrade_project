using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.DAL;
using WebAPI.Models_Table;
using WebAPI.ViewModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly AgroDbContext db;

        public ProductCategoryController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/ProductCategory
        [HttpGet]
        public ActionResult<IEnumerable<ProductCategoryVM>> GetProductCategory()
        {
            var data = (from pc in db.Product_Category
                        select new ProductCategoryVM
                        {
                            Product_Category_ID = pc.Product_Category_ID,
                            Product_Category_Name = pc.Product_Category_Name
                        }).ToList();
            return  Ok(data);
        }

        // GET: api/ProductCategory/5
        [HttpGet("{id}")]
        public ActionResult<ProductCategoryVM> GetProductCategory(int id)
        {
            var data = (from pc in db.Product_Category
                        select new ProductCategoryVM
                        {
                            Product_Category_ID = pc.Product_Category_ID,
                            Product_Category_Name = pc.Product_Category_Name
                        }).Where(i => i.Product_Category_ID == id).FirstOrDefault();           

            return Ok(data);
        }

        // PUT: api/ProductCategory/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductCategory(int id, ProductCategoryVM pcvm)
        {
            if (id != pcvm.Product_Category_ID)
            {
                return BadRequest();
            }

            Product_Category pc = new Product_Category();
           pc.Product_Category_ID = Convert.ToInt32(pcvm.Product_Category_ID);
            pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Entry(pc).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductCategory
        [HttpPost]
        public async Task<ActionResult<Product_Category>> PostProductCategory([FromBody]ProductCategoryVM pcvm)
        {
            Product_Category pc = new Product_Category();
            //pc.Product_Category_ID = Convert.ToInt32(pcvm.Product_Category_ID);
            pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Product_Category.Add(pc);

            //db.Entry(pc).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/ProductCategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product_Category>> DeleteProductCategory(int id)
        {
            var Product_Category = await db.Product_Category.FindAsync(id);
            if (Product_Category == null)
            {
                return NotFound();
            }

            db.Product_Category.Remove(Product_Category);
            await db.SaveChangesAsync();

            return Product_Category;
        }

        private bool Product_CategoryExists(int id)
        {
            return db.Product_Category.Any(e => e.Product_Category_ID == id);
        }
    }
}
