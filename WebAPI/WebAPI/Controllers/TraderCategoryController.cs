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
    public class TraderCategoryController : ControllerBase
    {
        private readonly AgroDbContext db;

        public TraderCategoryController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/TraderCategory
        [HttpGet]
        public ActionResult<IEnumerable<TraderCategoryVM>> GetTraderCategory()
        {
            var data = (from tc in db.Trader_Category
                        select new TraderCategoryVM
                        {
                            Trader_Category_ID = tc.Trader_Category_ID,
                            Trader_Category_Name = tc.Trader_Category_Name
                        }).ToList();
            return Ok(data);
        }

        // GET: api/TraderCategory/5
        [HttpGet("{id}")]
        public ActionResult<TraderCategoryVM> GetTraderCategory(int id)
        {
            var data = (from tc in db.Trader_Category
                        select new TraderCategoryVM
                        {
                            Trader_Category_ID = tc.Trader_Category_ID,
                            Trader_Category_Name = tc.Trader_Category_Name
                        }).Where(i => i.Trader_Category_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/TraderCategory/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTraderCategory(int id, TraderCategoryVM tcvm)
        {
            if (id != tcvm.Trader_Category_ID)
            {
                return BadRequest();
            }

            Trader_Category tc = new Trader_Category();
            tc.Trader_Category_ID = tcvm.Trader_Category_ID;
            tc.Trader_Category_Name = tcvm.Trader_Category_Name;

            db.Entry(tc).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Trader_CategoryExists(id))
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

        // POST: api/TraderCategory
        [HttpPost]
        public async Task<ActionResult<Trader_Category>> PostTraderCategory([FromBody]TraderCategoryVM tcvm)
        {
            Trader_Category tc = new Trader_Category();
            //tc.Trader_Category_ID = tcvm.Trader_Category_ID;
            tc.Trader_Category_Name = tcvm.Trader_Category_Name;

            db.Trader_Category.Add(tc);

            //db.Entry(tc).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok("Add succesful");
        }

        // DELETE: api/TraderCategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trader_Category>> DeleteTraderCategory(int id)
        {
            var Trader_Category = await db.Trader_Category.FindAsync(id);
            if (Trader_Category == null)
            {
                return NotFound();
            }

            db.Trader_Category.Remove(Trader_Category);
            await db.SaveChangesAsync();

            return Trader_Category;
        }

        private bool Trader_CategoryExists(int id)
        {
            return db.Trader_Category.Any(e => e.Trader_Category_ID == id);
        }
    }
}
