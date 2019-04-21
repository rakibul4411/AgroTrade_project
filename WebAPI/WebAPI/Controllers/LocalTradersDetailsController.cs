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
    public class LocalTradersDetailsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public LocalTradersDetailsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/LocalTradersDetails
        [HttpGet]
        public ActionResult<IEnumerable<LocalTradersDetailsVM>> GetLocalTradersDetails()
        {
            var data = (from ltd in db.Local_Traders_Details
                        select new LocalTradersDetailsVM
                        {
                            Local_Trader_ID = ltd.Local_Trader_ID,
                            Local_Trader_Name = ltd.Local_Trader_Name,
                            Local_Buying_Price = ltd.Local_Buying_Price,
                           Transportation_Cost = ltd.Transportation_Cost,
                            Storing_Cost = ltd.Storing_Cost,
                            Total_Cost = ltd.Total_Cost
                          
                        }).ToList();
            return Ok(data);
        }

        // GET: api/LocalTradersDetails/5
        [HttpGet("{id}")]
        public ActionResult<LocalTradersDetailsVM> GetLocalTradersDetails(int id)
        {
            var data = (from ltd in db.Local_Traders_Details
                        select new LocalTradersDetailsVM
                        {
                            Local_Trader_ID = ltd.Local_Trader_ID,
                            Local_Trader_Name = ltd.Local_Trader_Name,
                            Local_Buying_Price = ltd.Local_Buying_Price,
                            Transportation_Cost = ltd.Transportation_Cost,
                            Storing_Cost = ltd.Storing_Cost,
                            Total_Cost = ltd.Total_Cost
                        }).Where(i => i.Local_Trader_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/LocalTradersDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalTradersDetails(int id, LocalTradersDetailsVM ltdvm)
        {
            if (id != ltdvm.Local_Trader_ID)
            {
                return BadRequest();
            }
            Local_Traders_Details ltd = new Local_Traders_Details();
            ltd.Local_Trader_ID = Convert.ToInt32(ltdvm.Local_Trader_ID);

            ltd.Local_Trader_Name = ltdvm.Local_Trader_Name;
            ltd.Local_Buying_Price = ltdvm.Local_Buying_Price;
            ltd.Transportation_Cost = ltdvm.Transportation_Cost;
            ltd.Storing_Cost = ltdvm.Storing_Cost;
            ltd.Total_Cost = ltdvm.Total_Cost;
           
            db.Entry(ltd).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Local_Traders_DetailsExists(id))
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

        // POST: api/LocalTradersDetails
        [HttpPost]
        public async Task<ActionResult> PostLocalTradersDetails([FromBody]LocalTradersDetailsVM ltdvm)
        {
            Local_Traders_Details ltd = new Local_Traders_Details();
           // ltd.Local_Trader_ID = Convert.ToInt32(ltdvm.Local_Trader_ID);

            ltd.Local_Trader_Name = ltdvm.Local_Trader_Name;
            ltd.Local_Buying_Price = ltdvm.Local_Buying_Price;
            ltd.Transportation_Cost = ltdvm.Transportation_Cost;
            ltd.Storing_Cost = ltdvm.Storing_Cost;
            ltd.Total_Cost = ltdvm.Total_Cost;

            db.Local_Traders_Details.Add(ltd);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/LocalTradersDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Local_Traders_Details>> DeleteLocalTradersDetails(int id)
        {
            var Local_Traders_Details = await db.Local_Traders_Details.FindAsync(id);
            if (Local_Traders_Details == null)
            {
                return NotFound();
            }

            db.Local_Traders_Details.Remove(Local_Traders_Details);
            await db.SaveChangesAsync();

            return Local_Traders_Details;
        }

        private bool Local_Traders_DetailsExists(int id)
        {
            return db.Local_Traders_Details.Any(e => e.Local_Trader_ID == id);
        }

    }
}