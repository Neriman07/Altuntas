using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Altuntas.Data;
using Altuntas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Altuntas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
    private readonly ApplicationDbContext db;
    public SellersController(ApplicationDbContext db)
    {
      this.db = db;

    }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Seller>> Get()
        {
     
     /* var seller1 = new Seller();
      seller1.Name = "Altuntaş";
      db.Sellers.Add(seller1);
      db.SaveChanges();

      var buyer1 = new Buyer();
      buyer1.Name = "Bilişim Eğitim Merkezi";
      db.Buyers.Add(buyer1);
      db.SaveChanges();

      var sale1 = new Seller();
      sale1.SellerId = seller1.Id;
      sale1.BuyerId = buyer1.Id;
      sale1.Address = "Beşiktaş";
      sale1.Commission = 5;
      sale1.ExtraFormPrice = "10";
      sale1.Height = 3;
      sale1.InvoicaPrice = 100;
      sale1.Length = 50;
      sale1.Model = "3310";
      sale1.OurSellerPrice = 150;
      sale1.RecievedtForms = "ASASH";
      sale1.WarantyEndDate = DateTime.Now.AddYears(2);
      sale1.Width = 6;
      sale1.CreateDate = DateTime.Now;
      sale1.CreateBy = "username";
      sale1.UpdateDate = DateTime.Now;
      sale1.UpdateBy = "username";
      db.Sellers.Add(sale1);
      db.SaveChanges();*/
      var sales = db.Sellers.OrderBy(o => o.Name).ToList();

            return sales;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Seller seller)
        {
      db.Sellers.Add(seller);
      db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
