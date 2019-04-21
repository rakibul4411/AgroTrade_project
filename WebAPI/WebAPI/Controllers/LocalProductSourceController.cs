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
    public class LocalProductSourceController : ControllerBase
    {
        private readonly AgroDbContext db;

        public LocalProductSourceController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/LocalProductSource
        [HttpGet]
        public ActionResult<IEnumerable<LocalProductSourceVM>> GetLocalProductSource()
        {
            var data = (from lps in db.Local_Product_Source
                        select new LocalProductSourceVM
                        {
                            Local_Product_Source_ID = lps.Local_Product_Source_ID,
                            Seeding_Cost = lps.Seeding_Cost,
                            Ploughing_Cost = lps.Ploughing_Cost,
                            Watering_Cost = lps.Watering_Cost,
                            Labour_Cost = lps.Labour_Cost,
                            Processing_Cost = lps.Processing_Cost,
                            Total_Production_Cost = lps.Total_Production_Cost
                        }).ToList();
            return Ok(data);
        }

        // GET: api/LocalProductSource/5
        [HttpGet("{id}")]
        public ActionResult<LocalProductSourceVM> GetLocalProductSource(int id)
        {
            var data = (from lps in db.Local_Product_Source
                        select new LocalProductSourceVM
                        {
                            Local_Product_Source_ID = lps.Local_Product_Source_ID,
                            Seeding_Cost = lps.Seeding_Cost,
                            Ploughing_Cost = lps.Ploughing_Cost,
                            Watering_Cost = lps.Watering_Cost,
                            Labour_Cost = lps.Labour_Cost,
                            Processing_Cost = lps.Processing_Cost,
                            Total_Production_Cost = lps.Total_Production_Cost
                        }).Where(i => i.Local_Product_Source_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/LocalProductSource/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalProductSource(int id, LocalProductSourceVM lpsvm)
        {
            if (id != lpsvm.Local_Product_Source_ID)
            {
                return BadRequest();
            }
            Local_Product_Source lps = new Local_Product_Source();
            lps.Local_Product_Source_ID = Convert.ToInt32(lpsvm.Local_Product_Source_ID);

            lps.Seeding_Cost = lpsvm.Seeding_Cost;
            lps.Ploughing_Cost = lpsvm.Ploughing_Cost;
            lps.Watering_Cost = lpsvm.Watering_Cost;
            lps.Labour_Cost = lpsvm.Labour_Cost;
            lps.Processing_Cost = lpsvm.Processing_Cost;
            lps.Total_Production_Cost = lpsvm.Total_Production_Cost;
            

            db.Entry(lps).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Local_Product_SourceExists(id))
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

        // POST: api/LocalProductSource
        [HttpPost]
        public async Task<ActionResult> PostLocalProductSource([FromBody]  LocalProductSourceVM lpsvm)
        {
            Local_Product_Source lps = new Local_Product_Source();
            //fl.Farmer_ID = Convert.ToInt32(flvm.Farmer_ID);

            lps.Seeding_Cost = lpsvm.Seeding_Cost;
            lps.Ploughing_Cost = lpsvm.Ploughing_Cost;
            lps.Watering_Cost = lpsvm.Watering_Cost;
            lps.Labour_Cost = lpsvm.Labour_Cost;
            lps.Processing_Cost = lpsvm.Processing_Cost;
            lps.Total_Production_Cost = lpsvm.Total_Production_Cost;

            db.Local_Product_Source.Add(lps);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/LocalProductSource/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Local_Product_Source>> DeleteLocalProductSource(int id)
        {
            var Local_Product_Source = await db.Local_Product_Source.FindAsync(id);
            if (Local_Product_Source == null)
            {
                return NotFound();
            }

            db.Local_Product_Source.Remove(Local_Product_Source);
            await db.SaveChangesAsync();

            return Local_Product_Source;
        }

        private bool Local_Product_SourceExists(int id)
        {
            return db.Local_Product_Source.Any(e => e.Local_Product_Source_ID == id);
        }

    }
}