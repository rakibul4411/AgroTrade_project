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
    public class WholeSalerOrderDetailsController : ControllerBase
    {
        private readonly AgroDbContext db;

        public WholeSalerOrderDetailsController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/WholeSalerOrderDetails
        [HttpGet]
        public ActionResult<IEnumerable<WholeSalerOrderDetailsVM>> GetWholeSalerOrderDetails()
        {
            var data = (from wod in db.Whole_Saler_Order_Details
                        select new WholeSalerOrderDetailsVM
                        {
                            Order_ID = wod.Order_ID
                            //Product_Category_Name = pc.Product_Category_Name
                        }).ToList();
            return Ok(data);
        }

        // GET: api/WholeSalerOrderDetails/5
        [HttpGet("{id}")]
        public ActionResult<WholeSalerOrderDetailsVM> GetWholeSalerOrderDetails(int id)
        {
            var data = (from wod in db.Whole_Saler_Order_Details
                        select new WholeSalerOrderDetailsVM
                        {
                            Order_ID = wod.Order_ID

                            // Product_Category_Name = pc.Product_Category_Name
                        }).Where(i => i.Order_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/WholeSalerOrderDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWholeSalerOrderDetails(int id, WholeSalerOrderDetailsVM wodvm)
        {
            if (id != wodvm.Order_ID)
            {
                return BadRequest();
            }

            Whole_Saler_Order_Details wod = new Whole_Saler_Order_Details();
            wod.Order_ID = Convert.ToInt32(wodvm.Order_ID);

            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Entry(wod).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Whole_Saler_Order_DetailsExists(id))
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

        // POST: api/WholeSalerOrderDetails
        [HttpPost]
        public async Task<ActionResult<Whole_Saler_Order_Details>> PostWholeSalerOrderDetails([FromBody]WholeSalerOrderDetailsVM wodvm)
        {
            Whole_Saler_Order_Details wod = new Whole_Saler_Order_Details();
            wod.Order_ID = Convert.ToInt32(wodvm.Order_ID);
            //pc.Product_Category_Name = pcvm.Product_Category_Name;

            db.Whole_Saler_Order_Details.Add(wod);


            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/WholeSalerOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Whole_Saler_Order_Details>> DeleteWholeSalerOrderDetails(int id)
        {
            var Whole_Saler_Order_Details = await db.Whole_Saler_Order_Details.FindAsync(id);
            if (Whole_Saler_Order_Details == null)
            {
                return NotFound();
            }

            db.Whole_Saler_Order_Details.Remove(Whole_Saler_Order_Details);
            await db.SaveChangesAsync();

            return Whole_Saler_Order_Details;
        }

        private bool Whole_Saler_Order_DetailsExists(int id)
        {
            return db.Whole_Saler_Order_Details.Any(e => e.Order_ID == id);
        }
    }
}
