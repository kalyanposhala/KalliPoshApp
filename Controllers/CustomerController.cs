using KalliPoshApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KalliPoshApp.ViewModel;

namespace KalliPoshApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerDetail
        public ActionResult Index()
        {
            var model = GetCustomer();
            var viewmodel = new RandamMovieViewModel();
            viewmodel.Customers = model;
            return View(viewmodel);
        }
        public ActionResult Detail(int Id)
        {
            var model = GetCustomer().Where(x =>x.Id ==Id).FirstOrDefault();
            return View(model);
        }

        private List<Customer> GetCustomer()
        {
            return new List<Customer>
        {
            new Customer{ Id =1, Name = "Kalyan Poshala"},
            new Customer{ Id=2, Name ="Kalli Posh"}
        };
        }
    }


}
