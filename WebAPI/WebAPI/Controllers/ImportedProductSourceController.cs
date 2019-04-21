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
    public class ImportedProductSourceController : ControllerBase
    {
        private readonly AgroDbContext db;

        public ImportedProductSourceController(AgroDbContext context)
        {
            db = context;
        }

        // GET: api/ImportedProductSource
        [HttpGet]
        public ActionResult<IEnumerable<ImportedProductSourceVM>> GetImportedProductSource()
        {
            var data = (from ips in db.Imported_Product_Source
                        select new ImportedProductSourceVM
                        {
                            Imported_Product_Source_ID = ips.Imported_Product_Source_ID,
                            Imported_Product_Buying_Cost = ips.Imported_Product_Buying_Cost,
                            Shipment_Cost = ips.Shipment_Cost,
                            Custom_Tax = ips.Custom_Tax,
                            Transportation_Cost=ips.Transportation_Cost,
                            Storing_Cost=ips.Storing_Cost,
                            Total_Cost=ips.Total_Cost,
                            Importers_WholeSale_Price=ips.Importers_WholeSale_Price
                        }).ToList();
            return Ok(data);
        }

        // GET: api/ImportedProductSource/5
        [HttpGet("{id}")]
        public ActionResult<ImportedProductSourceVM> GetImportedProductSource(int id)
        {
            var data = (from ips in db.Imported_Product_Source
                        select new ImportedProductSourceVM
                        {
                            Imported_Product_Source_ID = ips.Imported_Product_Source_ID,
                            Imported_Product_Buying_Cost = ips.Imported_Product_Buying_Cost,
                            Shipment_Cost = ips.Shipment_Cost,
                            Custom_Tax = ips.Custom_Tax,
                            Transportation_Cost = ips.Transportation_Cost,
                            Storing_Cost = ips.Storing_Cost,
                            Total_Cost = ips.Total_Cost,
                            Importers_WholeSale_Price = ips.Importers_WholeSale_Price
                        }).Where(i => i.Imported_Product_Source_ID == id).FirstOrDefault();

            return Ok(data);
        }

        // PUT: api/ImportedProductSource/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportedProductSource(int id, ImportedProductSourceVM ipsvm)
        {
            if (id != ipsvm.Imported_Product_Source_ID)
            {
                return BadRequest();
            }
            Imported_Product_Source ips = new Imported_Product_Source();
            ips.Imported_Product_Source_ID = Convert.ToInt32(ipsvm.Imported_Product_Source_ID);

            ips.Imported_Product_Buying_Cost = ipsvm.Imported_Product_Buying_Cost;
            ips.Shipment_Cost = ipsvm.Shipment_Cost;
            ips.Custom_Tax = ipsvm.Custom_Tax;
            ips.Transportation_Cost = ipsvm.Transportation_Cost;
            ips.Storing_Cost = ipsvm.Storing_Cost;
            ips.Total_Cost = ipsvm.Total_Cost;
            ips.Importers_WholeSale_Price = ipsvm.Importers_WholeSale_Price;

            db.Entry(ips).State = EntityState.Modified;
            await db.SaveChangesAsync();

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Imported_Product_SourceExists(id))
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

        // POST: api/ImportedProductSource
        [HttpPost]
        public async Task<ActionResult> PostImportedProductSource([FromBody]ImportedProductSourceVM ipsvm)
        {
            Imported_Product_Source ips = new Imported_Product_Source();
            //fl.Farmer_ID = Convert.ToInt32(flvm.Farmer_ID);

            ips.Imported_Product_Buying_Cost = ipsvm.Imported_Product_Buying_Cost;
            ips.Shipment_Cost = ipsvm.Shipment_Cost;
            ips.Custom_Tax = ipsvm.Custom_Tax;
            ips.Transportation_Cost = ipsvm.Transportation_Cost;
            ips.Storing_Cost = ipsvm.Storing_Cost;
            ips.Total_Cost = ipsvm.Total_Cost;
            ips.Importers_WholeSale_Price = ipsvm.Importers_WholeSale_Price;

            db.Imported_Product_Source.Add(ips);

            await db.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/ImportedProductSource/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Imported_Product_Source>> DeleteImportedProductSource(int id)
        {
            var Imported_Product_Source = await db.Imported_Product_Source.FindAsync(id);
            if (Imported_Product_Source == null)
            {
                return NotFound();
            }

            db.Imported_Product_Source.Remove(Imported_Product_Source);
            await db.SaveChangesAsync();

            return Imported_Product_Source;
        }

        private bool Imported_Product_SourceExists(int id)
        {
            return db.Imported_Product_Source.Any(e => e.Imported_Product_Source_ID == id);
        }

    }
}