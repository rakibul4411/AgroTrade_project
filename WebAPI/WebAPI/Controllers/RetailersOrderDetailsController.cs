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
    public class RetailersOrderDetailsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public RetailersOrderDetailsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/RetailerOrderDetails
        [HttpGet]
        public ActionResult<IEnumerable<RetailersOrderDetailsVM>> GetRetailerOrderDetails()
        {
            var data = (from rod in db.Retailers_Order_Details
                        select new RetailersOrderDetailsVM
                        {
                            Retailer_Order_ID = rod.Retailer_Order_ID
                            //Product_Category_Name = pc.Product_Category_Name
                        }).ToList();
            return Ok(data);
        }

        // GET: api/RetailerOrderDetails/5
        [HttpGet("{id}")]
        public ActionResult<RetailersOrderDetailsVM> GetRetailerOrderDetails(int id)
        {
            var data = (from rod in db.Retailers_Order_Details
                        select new RetailersOrderDetailsVM
                        {
                            Retailer_Order_ID = rod.Retailer_Order_ID

                            // Product_Category_Name = pc.Product_Category_Name
                        }).Where(i => i.Retailer_Order_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/RetailerOrderDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRetailerOrderDetails(int id, RetailersOrderDetailsVM rodvm)
        {
            if (id != rodvm.Retailer_Order_ID)
            {
                return BadRequest();
            }

            Retailers_Order_Details rod = new Retailers_Order_Details();
            rod.Retailer_Order_ID = Convert.ToInt32(rodvm.Retailer_Order_ID);

            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Entry(rod).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Retailer_Order_DetailsExists(id))
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

        // POST: api/RetailerOrderDetails
        [HttpPost]
        public async Task<ActionResult<Retailers_Order_Details>> PostRetailerOrderDetails([FromBody]RetailersOrderDetailsVM rodvm)
        {
            Retailers_Order_Details rod = new Retailers_Order_Details();
            rod.Retailer_Order_ID = Convert.ToInt32(rodvm.Retailer_Order_ID);
            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Retailers_Order_Details.Add(rod);


            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/RetailerOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Retailers_Order_Details>> DeleteRetailerOrderDetails(int id)
        {
            var Retailers_Order_Details = await db.Retailers_Order_Details.FindAsync(id);
            if (Retailers_Order_Details == null)
            {
                return NotFound();
            }

            db.Retailers_Order_Details.Remove(Retailers_Order_Details);
            await db.SaveChangesAsync();

            return Retailers_Order_Details;
        }

        private bool Retailer_Order_DetailsExists(int id)
        {
            return db.Retailers_Order_Details.Any(e => e.Retailer_Order_ID == id);
        }
    }
}
