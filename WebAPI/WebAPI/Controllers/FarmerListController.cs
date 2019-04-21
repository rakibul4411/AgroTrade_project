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
    public class FarmerListController : ControllerBase
    {
        private readonly AgroDbContext db;

        public FarmerListController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/FarmerList
        [HttpGet]
        public ActionResult<IEnumerable<FarmerListVM>> GetFarmerList()
        {
            var data = (from fl in db.Farmer_List
                        select new FarmerListVM
                        {
                            Farmer_ID = fl.Farmer_ID,
                            Farmer_Name = fl.Farmer_Name,
                            Address = fl.Address,
                            Phone = fl.Phone
                        }).ToList();
            return Ok(data);
        }

        // GET: api/FarmerList/5
        [HttpGet("{id}")]
        public ActionResult<FarmerListVM> GetFarmerList(int id)
        {
            var data = (from fl in db.Farmer_List
                        select new FarmerListVM
                        {
                            Farmer_ID = fl.Farmer_ID,
                            Farmer_Name = fl.Farmer_Name,
                            Address = fl.Address,
                            Phone = fl.Phone
                        }).Where(i => i.Farmer_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/FarmerList/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFarmerList(int id, FarmerListVM flvm)
        {
            if (id != flvm.Farmer_ID)
            {
                return BadRequest();
            }

            Farmer_List fl = new Farmer_List();

            fl.Farmer_ID = Convert.ToInt32(flvm.Farmer_ID);

            fl.Farmer_Name = flvm.Farmer_Name;
            fl.Address = flvm.Address;
            fl.Phone = flvm.Phone;

            db.Entry(fl).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Farmer_ListExists(id))
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

        // POST: api/FarmerList
        [HttpPost]
        public async Task<ActionResult> PostFarmerList([FromBody]FarmerListVM flvm)
        {
            Farmer_List fl = new Farmer_List();
            //fl.Farmer_ID = Convert.ToInt32(flvm.Farmer_ID);
            fl.Farmer_Name = flvm.Farmer_Name;
            fl.Address = flvm.Address;
            fl.Phone = flvm.Phone;

            db.Farmer_List.Add(fl);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/FarmerList/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Farmer_List>> DeleteFarmerList(int id)
        {
            var Farmer_List = await db.Farmer_List.FindAsync(id);
            if (Farmer_List == null)
            {
                return NotFound();
            }

            db.Farmer_List.Remove(Farmer_List);
            await db.SaveChangesAsync();

            return Farmer_List;
        }

        private bool Farmer_ListExists(int id)
        {
            return db.Farmer_List.Any(e => e.Farmer_ID == id);
        }

    }
}