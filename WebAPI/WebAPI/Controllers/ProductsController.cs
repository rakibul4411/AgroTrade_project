using System;
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
    public class ProductsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public ProductsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductsVM>> GetProducts()
        {
            var data = (from p in db.Products
                        select new ProductsVM
                        {
                            Product_ID = p.Product_ID,
                            Product_Name = p.Product_Name,
                            Details = p.Details,
                            Product_Source =p.Product_Source
                            
                        }).ToList();
            return Ok(data);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<ProductsVM> GetProducts(int id)
        {
            var data = (from p in db.Products
                        select new ProductsVM
                        {
                            Product_ID = p.Product_ID,
                            Product_Name = p.Product_Name,
                            Details = p.Details,
                            Product_Source = p.Product_Source   
                        }).Where(i => i.Product_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, ProductsVM pvm)
        {
            if (id != pvm.Product_ID)
            {
                return BadRequest();
            }

            Products p = new Products();
            p.Product_ID = Convert.ToInt32(pvm.Product_ID);
            p.Product_Name = pvm.Product_Name;
            p.Details = pvm.Details;
            p.Product_Source = pvm.Product_Source;
            
            db.Entry(p).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(id))
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

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Products>> PostProducts([FromBody]ProductsVM pvm)
        {
            Products p = new Products();
            //pc.Product_Category_ID = Convert.ToInt32(pcvm.Product_Category_ID);
            p.Product_Name = pvm.Product_Name;
            p.Details = pvm.Details;
            p.Product_Source = pvm.Product_Source;
           

            db.Products.Add(p);

            //db.Entry(pc).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Products>> DeleteProducts(int id)
        {
            var Products = await db.Products.FindAsync(id);
            if (Products== null)
            {
                return NotFound();
            }

            db.Products.Remove(Products);
            await db.SaveChangesAsync();

            return Products;
        }

        private bool ProductsExists(int id)
        {
            return db.Products.Any(e => e.Product_ID == id);
        }
    }
}
