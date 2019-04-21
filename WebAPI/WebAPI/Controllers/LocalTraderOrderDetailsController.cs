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
    public class LocalTraderOrderDetailsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public LocalTraderOrderDetailsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/LocalTraderOrderDetails
        [HttpGet]
        public ActionResult<IEnumerable<LocalTraderOrderDetailsVM>> GetLocalTraderOrderDetails()
        {
            var data = (from ltod in db.Local_Trader_Order_Details
                        select new LocalTraderOrderDetailsVM
                        {
                            Local_Trader_Order_ID = ltod.Local_Trader_Order_ID
                            //Product_Category_Name = pc.Product_Category_Name
                        }).ToList();
            return Ok(data);
        }

        // GET: api/LocalTraderOrderDetails/5
        [HttpGet("{id}")]
        public ActionResult<LocalTraderOrderDetailsVM> GetLocalTraderOrderDetails(int id)
        {
            var data = (from ltod in db.Local_Trader_Order_Details
                        select new LocalTraderOrderDetailsVM
                        {
                            Local_Trader_Order_ID = ltod.Local_Trader_Order_ID

                           // Product_Category_Name = pc.Product_Category_Name
                        }).Where(i => i.Local_Trader_Order_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/LocalTraderOrderDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalTraderOrderDetails(int id, LocalTraderOrderDetailsVM ltodvm)
        {
            if (id != ltodvm.Local_Trader_Order_ID)
            {
                return BadRequest();
            }

            Local_Trader_Order_Details ltod = new Local_Trader_Order_Details();
            ltod.Local_Trader_Order_ID = Convert.ToInt32(ltodvm.Local_Trader_Order_ID);

            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Entry(ltod).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Local_Trader_Order_DetailsExists(id))
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

        // POST: api/LocalTraderOrderDetails
        [HttpPost]
        public async Task<ActionResult<Local_Trader_Order_Details>> PostLocalTraderOrderDetails([FromBody]LocalTraderOrderDetailsVM ltodvm)
        {
            Local_Trader_Order_Details ltod = new Local_Trader_Order_Details();
           ltod.Local_Trader_Order_ID = Convert.ToInt32(ltodvm.Local_Trader_Order_ID);
            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Local_Trader_Order_Details.Add(ltod);

            
            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/LocalTraderOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Local_Trader_Order_Details>> DeleteLocalTraderOrderDetails(int id)
        {
            var Local_Trader_Order_Details = await db.Local_Trader_Order_Details.FindAsync(id);
            if (Local_Trader_Order_Details == null)
            {
                return NotFound();
            }

            db.Local_Trader_Order_Details.Remove(Local_Trader_Order_Details);
            await db.SaveChangesAsync();

            return Local_Trader_Order_Details;
        }

        private bool Local_Trader_Order_DetailsExists(int id)
        {
            return db.Local_Trader_Order_Details.Any(e => e.Local_Trader_Order_ID == id);
        }
    }
}
