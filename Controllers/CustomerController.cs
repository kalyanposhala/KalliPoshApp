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
        KalliPoshDbEntities1 _DbContext = new KalliPoshDbEntities1();

        
        // GET: CustomerDetail
        public ActionResult Index()
        {
            //var model = _DbContext.Customers.ToList();
            List<KalliPoshApp.Models.Customers> uiCustomer = new List<Models.Customers>();
            var dbModel = _DbContext.Customers.ToList();
            foreach (var item in dbModel)
            {
                uiCustomer.Add(new Models.Customers()
                {
                    Id = item.Id,
                    Name = item.Name


                });
            }
            //var viewmodel = new RandamMovieViewModel();
            //viewmodel.Customers = model;
            return View(uiCustomer);
        }
        public ActionResult Detail(int Id)
        {
            KalliPoshApp.Models.Customers uiCustomer = new Models.Customers();

            var model = _DbContext.Customers.Where(x =>x.Id ==Id).FirstOrDefault();
            uiCustomer.Name = model.Name;
            return View(uiCustomer);
        }

        //private List<Customer> GetCustomer()
        //{
        //    return new List<Customer>
        //{
        //    new Customer{ Id =1, Name = "Kalyan Poshala"},
        //    new Customer{ Id=2, Name ="Kalli Posh"}
        //};
        //}
    }


}
