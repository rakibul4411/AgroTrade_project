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
    public class TradersListController : ControllerBase
    {
        private readonly AgroDbContext db;

        public TradersListController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/TradersList
        [HttpGet]
        public ActionResult<IEnumerable<TradersListVM>> GetTradersList()
        {
            var data = (from tl in db.Traders_List
                        select new TradersListVM
                        {
                            Trader_ID = tl.Trader_ID,
                            Trader_Name = tl.Trader_Name,
                            Trader_Address = tl.Trader_Address
                       
                        }).ToList();
            return Ok(data);
        }

        // GET: api/TradersList/5
        [HttpGet("{id}")]
        public ActionResult<TradersListVM> GetTradersList(int id)
        {
            var data = (from tl in db.Traders_List
                        select new TradersListVM
                        {
                            Trader_ID = tl.Trader_ID,
                            Trader_Name = tl.Trader_Name,
                            Trader_Address = tl.Trader_Address
                        }).Where(i => i.Trader_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/TradersList/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradersList(int id, TradersListVM tlvm)
        {
            if (id != tlvm.Trader_ID)
            {
                return BadRequest();
            }
            Traders_List tl = new Traders_List();
            tl.Trader_ID = Convert.ToInt32(tlvm.Trader_ID);
            tl.Trader_Name = tlvm.Trader_Name;
            tl.Trader_Address = tlvm.Trader_Address;

            db.Entry(tl).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Traders_ListExists(id))
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

        // POST: api/TradersList
        [HttpPost]
        public async Task<ActionResult> PostTradersList([FromBody]TradersListVM tlvm)
        {
            Traders_List tl = new Traders_List();
            tl.Trader_ID = Convert.ToInt32(tlvm.Trader_ID);
            tl.Trader_Name = tlvm.Trader_Name;
            tl.Trader_Address = tlvm.Trader_Address;

            db.Traders_List.Add(tl);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/TradersList/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Traders_List>> DeleteTradersList(int id)
        {
            var Traders_List = await db.Traders_List.FindAsync(id);
            if (Traders_List == null)
            {
                return NotFound();
            }

            db.Traders_List.Remove(Traders_List);
            await db.SaveChangesAsync();

            return Traders_List;
        }

        private bool Traders_ListExists(int id)
        {
            return db.Traders_List.Any(e => e.Trader_ID == id);
        }

    }
}