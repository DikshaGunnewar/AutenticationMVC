using AspNetIdentity.WebApi.Infrastructure;
using AspNetIdentity.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetIdentity.WebApi.Controllers
{
    public class HomeController : ApiController
    {
        ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        // GET: api/Customers  
        [HttpGet]
        [Route("api/Customer/GetCustomers")]
        public IHttpActionResult GetCustomers()
        {
            var customer = db.Customers.ToList();
            return Ok(customer);
        }
        [HttpGet]
        [Route("api/Customer/GetCustomerById/{id}")]
        public IHttpActionResult GetCustomerById(int id)
        {
            var customer = db.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
                return Ok(customer);
            else
                return NotFound();
        }
        [HttpPost]
        [Route("api/Customer/SaveCustomer")]
        public IHttpActionResult SaveCustomer(Customer customer)
        {
            if (customer.Id > 0)
            {
                var dbCustomer = db.Customers.FirstOrDefault(x => x.Id == customer.Id);
                dbCustomer.Name = customer.Name;
                dbCustomer.Email = customer.Email;
                dbCustomer.Password = customer.Password;
                db.SaveChanges();
            }
            else
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            return Ok(customer.Id);
        }
        [HttpDelete]
        [Route("api/Customer/DeleteCustomer/{id}")]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customer = new Customer { Id = id };
            db.Customers.Attach(customer);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return Ok(id);
        }
    }
}
