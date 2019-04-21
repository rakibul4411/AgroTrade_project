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
    public class ProductUnitController : ControllerBase
    {
        private readonly AgroDbContext db1;

        public ProductUnitController(AgroDbContext context)
        {
            db1 = context;
        }

        // GET: api/ProductUnit
        [HttpGet]
        public ActionResult<IEnumerable<ProductUnitVM>> GetProductUnit()
        {
            var data = (from pu in db1.Product_Unit
                        select new ProductUnitVM
                        {
                            Product_Unit_ID = pu.Product_Unit_ID,
                            Product_Unit_Quantity = pu.Product_Unit_Quantity
                        }).ToList();
            return Ok(data);
        }

        // GET: api/ProductUnit/5
        [HttpGet("{id}")]
        public ActionResult<ProductUnitVM> GetProductUnit(int id)
        {
            var data = (from pu in db1.Product_Unit
                        select new ProductUnitVM
                        {
                            Product_Unit_ID = pu.Product_Unit_ID,
                            Product_Unit_Quantity = pu.Product_Unit_Quantity
                        }).Where(i => i.Product_Unit_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/ProductUnit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductUnit(int id, ProductUnitVM puvm)
        {
            if (id != puvm.Product_Unit_ID)
            {
                return BadRequest();
            }

            Product_Unit pu = new Product_Unit();
            pu.Product_Unit_ID = puvm.Product_Unit_ID;
            pu.Product_Unit_Quantity = puvm.Product_Unit_Quantity;

            db1.Entry(pu).State = EntityState.Modified;
            await db1.SaveChangesAsync();

            try
            {
                await db1.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_UnitExists(id))
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

        // POST: api/ProductUnit
        [HttpPost]
        public async Task<ActionResult<Product_Unit>> PostProductUnit([FromBody]ProductUnitVM puvm)
        {
            Product_Unit pu = new Product_Unit();
            //pu.Product_Unit_ID = puvm.Product_Unit_ID;
            pu.Product_Unit_Quantity = puvm.Product_Unit_Quantity;

            db1.Product_Unit.Add(pu);

            //db1.Entry(pu).State = EntityState.Modified;
            await db1.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/ProductUnit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product_Unit>> DeleteProductUnit(int id)
        {
            var product_Unit = await db1.Product_Unit.FindAsync(id);
            if (product_Unit == null)
            {
                return NotFound();
            }

            db1.Product_Unit.Remove(product_Unit);
            await db1.SaveChangesAsync();

            return product_Unit;
        }

        private bool Product_UnitExists(int id)
        {
            return db1.Product_Unit.Any(e => e.Product_Unit_ID == id);
        }
    }
}
