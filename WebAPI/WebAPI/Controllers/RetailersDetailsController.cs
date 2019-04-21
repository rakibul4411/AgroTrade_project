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
    public class RetailersDetailsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public RetailersDetailsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/RetailersDetails
        [HttpGet]
        public ActionResult<IEnumerable<RetailersDetailsVM>> GetRetailersDetails()
        {
            var data = (from rd in db.Retailers_Details
                        select new RetailersDetailsVM
                        {
                            Retailer_ID = rd.Retailer_ID,
                            Retailer_Name = rd.Retailer_Name,
                            Retailers_Buying_Price = rd.Retailers_Buying_Price,
                            Transportation_Cost = rd.Transportation_Cost,
                            Total_Cost_PerUnit = rd.Total_Cost_PerUnit,
                            Retailer_Selling_Price = rd.Retailer_Selling_Price

                        }).ToList();
            return Ok(data);
        }

        // GET: api/RetailersDetails/5
        [HttpGet("{id}")]
        public ActionResult<RetailersDetailsVM> GetRetailersDetails(int id)
        {
            var data = (from rd in db.Retailers_Details
                        select new RetailersDetailsVM
                        {
                            Retailer_ID = rd.Retailer_ID,
                            Retailer_Name = rd.Retailer_Name,
                            Retailers_Buying_Price = rd.Retailers_Buying_Price,
                            Transportation_Cost = rd.Transportation_Cost,
                            Total_Cost_PerUnit = rd.Total_Cost_PerUnit,
                            Retailer_Selling_Price = rd.Retailer_Selling_Price

                        }).Where(i => i.Retailer_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/RetailersDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRetailersDetails(int id, RetailersDetailsVM rdvm)
        {
            if (id != rdvm.Retailer_ID)
            {
                return BadRequest();
            }
            Retailers_Details rd = new Retailers_Details();
            rd.Retailer_ID = Convert.ToInt32(rdvm.Retailer_ID);

            rd.Retailer_Name = rdvm.Retailer_Name;
            rd.Retailers_Buying_Price = rdvm.Retailers_Buying_Price;
            rd.Transportation_Cost = rdvm.Transportation_Cost;
            rd.Total_Cost_PerUnit = rdvm.Total_Cost_PerUnit;
            rd.Retailer_Selling_Price = rdvm.Retailer_Selling_Price;

            db.Entry(rd).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Retailers_DetailsExists(id))
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

        // POST: api/RetailersDetails
        [HttpPost]
        public async Task<ActionResult> PostRetailersDetails([FromBody]RetailersDetailsVM rdvm)
        {
            Retailers_Details rd = new Retailers_Details();
            //rd.Retailer_ID = Convert.ToInt32(rdvm.Retailer_ID);

            rd.Retailer_Name = rdvm.Retailer_Name;
            rd.Retailers_Buying_Price = rdvm.Retailers_Buying_Price;
            rd.Transportation_Cost = rdvm.Transportation_Cost;
            rd.Total_Cost_PerUnit = rdvm.Total_Cost_PerUnit;
            rd.Retailer_Selling_Price = rdvm.Retailer_Selling_Price;

            db.Retailers_Details.Add(rd);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/RetailersDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Retailers_Details>> DeleteRetailersDetails(int id)
        {
            var Retailers_Details = await db.Retailers_Details.FindAsync(id);
            if (Retailers_Details == null)
            {
                return NotFound();
            }

            db.Retailers_Details.Remove(Retailers_Details);
            await db.SaveChangesAsync();

            return Retailers_Details;
        }

        private bool Retailers_DetailsExists(int id)
        {
            return db.Retailers_Details.Any(e => e.Retailer_ID == id);
        }

    }
}