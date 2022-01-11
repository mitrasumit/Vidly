using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers")]
        public ViewResult Index()
        {
            var customer = GetCustomer();

            return View(customer);
        }

        public IEnumerable<Customer> GetCustomer()
        {

            var customer = new List<Customer>
            {
                new Customer{Id=1, Name="Sumit Mitra"},
                new Customer{Id=2, Name="Rishav Sarkar"}
            };

            return customer;
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);   //SingleorDefault returns a sngle value if present or returns null

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
    }
}