using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.Entity;
namespace WebApplication2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext context;
        public CustomersController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {

            context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = context.Customers.Include(c => c.membershiptype).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = context.Customers.Include(c=> c.membershiptype).SingleOrDefault(c => c.ID ==id);
            return View(customer);
        }
        private IEnumerable<Customers> GetCustomers()
        {
            return context.Customers;
        }
    }
}