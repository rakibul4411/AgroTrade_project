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
    public class WholeSalersController : ControllerBase
    {
        private readonly AgroDbContext db;

        public WholeSalersController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/WholeSalers
        [HttpGet]
        public ActionResult<IEnumerable<WholeSalersVM>> GetWholeSalers()
        {
            var data = (from ws in db.Whole_Salers
                        select new WholeSalersVM
                        {
                            Whole_Saler_ID = ws.Whole_Saler_ID,
                            Whole_Saler_Name = ws.Whole_Saler_Name,
                            Whole_Saler_Buying_Cost = ws.Whole_Saler_Buying_Cost,
                            Whole_Saler_Transportation_Cost = ws.Whole_Saler_Transportation_Cost,
                            Whole_Saler_Storing_Cost = ws.Whole_Saler_Storing_Cost,
                            Whole_Saler_Total_Cost = ws.Whole_Saler_Total_Cost,
                            Whole_Saler_Selling_Price=ws.Whole_Saler_Selling_Price

                        }).ToList();
            return Ok(data);
        }

        // GET: api/WholeSalers/5
        [HttpGet("{id}")]
        public ActionResult<WholeSalersVM> GetWholeSalers(int id)
        {
            var data = (from ws in db.Whole_Salers
                        select new WholeSalersVM
                        {
                            Whole_Saler_ID = ws.Whole_Saler_ID,
                            Whole_Saler_Name = ws.Whole_Saler_Name,
                            Whole_Saler_Buying_Cost = ws.Whole_Saler_Buying_Cost,
                            Whole_Saler_Transportation_Cost = ws.Whole_Saler_Transportation_Cost,
                            Whole_Saler_Storing_Cost = ws.Whole_Saler_Storing_Cost,
                            Whole_Saler_Total_Cost = ws.Whole_Saler_Total_Cost,
                            Whole_Saler_Selling_Price = ws.Whole_Saler_Selling_Price
                        }).Where(i => i.Whole_Saler_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/Whole_Salers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWholeSalers(int id, WholeSalersVM wsvm)
        {
            if (id != wsvm.Whole_Saler_ID)
            {
                return BadRequest();
            }

            Whole_Salers ws = new Whole_Salers();

            ws.Whole_Saler_ID = Convert.ToInt32(wsvm.Whole_Saler_ID);

            ws.Whole_Saler_Name = wsvm.Whole_Saler_Name;
            ws.Whole_Saler_Buying_Cost = wsvm.Whole_Saler_Buying_Cost;
            ws.Whole_Saler_Transportation_Cost = wsvm.Whole_Saler_Transportation_Cost;
            ws.Whole_Saler_Storing_Cost = wsvm.Whole_Saler_Storing_Cost;
            ws.Whole_Saler_Total_Cost = wsvm.Whole_Saler_Total_Cost;
            ws.Whole_Saler_Selling_Price = wsvm.Whole_Saler_Selling_Price;

            db.Entry(ws).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Whole_SalersExists(id))
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

        // POST: api/WholeSalers
        [HttpPost]
        public async Task<ActionResult> PostWholeSalers([FromBody]WholeSalersVM wsvm)
        {
            Whole_Salers ws = new Whole_Salers();
           // ws.Whole_Saler_ID = Convert.ToInt32(wsvm.Whole_Saler_ID);
            ws.Whole_Saler_Name = wsvm.Whole_Saler_Name;
            ws.Whole_Saler_Buying_Cost = wsvm.Whole_Saler_Buying_Cost;
            ws.Whole_Saler_Transportation_Cost = wsvm.Whole_Saler_Transportation_Cost;
            ws.Whole_Saler_Storing_Cost = wsvm.Whole_Saler_Storing_Cost;
            ws.Whole_Saler_Total_Cost = wsvm.Whole_Saler_Total_Cost;
            ws.Whole_Saler_Selling_Price = wsvm.Whole_Saler_Selling_Price;

            db.Whole_Salers.Add(ws);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/WholeSalers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Whole_Salers>> DeleteWholeSalers(int id)
        {
            var Whole_Salers = await db.Whole_Salers.FindAsync(id);
            if (Whole_Salers == null)
            {
                return NotFound();
            }

            db.Whole_Salers.Remove(Whole_Salers);
            await db.SaveChangesAsync();

            return Whole_Salers;
        }

        private bool Whole_SalersExists(int id)
        {
            return db.Whole_Salers.Any(e => e.Whole_Saler_ID == id);
        }

    }
}