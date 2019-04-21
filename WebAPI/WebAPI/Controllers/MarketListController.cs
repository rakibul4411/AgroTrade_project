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
    public class MarketListController : ControllerBase
    {
        private readonly AgroDbContext db;

        public MarketListController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/MarketList
        [HttpGet]
        public ActionResult<IEnumerable<MarketListVM>> GetMarketList()
        {
            var data = (from ml in db.Market_List
                        select new MarketListVM
                        {
                            Market_ID = ml.Market_ID,
                            Market_Name = ml.Market_Name,
                            Market_Address = ml.Market_Address,
                            Post_Code = ml.Post_Code,
                            District = ml.District,
                            Country_Name = ml.Country_Name
                        }).ToList();
            return Ok(data);
        }

        // GET: api/MarketList/5
        [HttpGet("{id}")]
        public ActionResult<MarketListVM> GetMarketList(int id)
        {
            var data = (from ml in db.Market_List
                        select new MarketListVM
                        {
                            Market_ID = ml.Market_ID,
                            Market_Name = ml.Market_Name,
                            Market_Address = ml.Market_Address,
                            Post_Code = ml.Post_Code,
                            District = ml.District,
                            Country_Name = ml.Country_Name
                        }).Where(i => i.Market_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/MarketList/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarketList(int id, MarketListVM mlvm)
        {
            if (id != mlvm.Market_ID)
            {
                return BadRequest();
            }
            Market_List ml = new Market_List();
            ml.Market_ID =Convert.ToInt32( mlvm.Market_ID);
            ml.Market_Name = mlvm.Market_Name;
            ml.Market_Address = mlvm.Market_Address;
            ml.Post_Code = mlvm.Post_Code;
            ml.District = mlvm.District;
            ml.Country_Name = mlvm.Country_Name;

            db.Entry(ml).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Market_ListExists(id))
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

        // POST: api/MarketList
        [HttpPost]
        public async Task<ActionResult<Market_List>> PostMarketList([FromBody]MarketListVM mlvm)
        {
            Market_List ml = new Market_List();
           // ml.Market_ID = mlvm.Market_ID;
            ml.Market_Name = mlvm.Market_Name;
            ml.Market_Address = mlvm.Market_Address;
            ml.Post_Code = mlvm.Post_Code;
            ml.District = mlvm.District;
            ml.Country_Name = mlvm.Country_Name;

            db.Market_List.Add(ml);

            // db.Entry(ml).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/MarketList/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Market_List>> DeleteMarketList(int id)
        {
            var Market_List = await db.Market_List.FindAsync(id);
            if (Market_List == null)
            {
                return NotFound();
            }

            db.Market_List.Remove(Market_List);
            await db.SaveChangesAsync();

            return Market_List;
        }

        private bool Market_ListExists(int id)
        {
            return db.Market_List.Any(e => e.Market_ID == id);
        }

    }
}