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
            List<KalliPoshApp.Models.Customers> uiCustomer = new List<KalliPoshApp.Models.Customers>();
            var viewmodel = new RandamMovieViewModel();
            var dbModel = _DbContext.Customers.ToList();

            foreach (var item in dbModel)
            {
                var dbMembershipList = _DbContext.MembershipTypes.Where(x => x.Id == item.MembershipTypeId).FirstOrDefault();

                uiCustomer.Add(new Models.Customers()
                {
                    Id = item.Id,
                    Name = item.Name,
                    IsSubscribedToNewsLetter = item.IsSubscribedToNewsLetter,
                    MembershipName = dbMembershipList.MembershipName,
                    MembershipTypeId = Convert.ToByte(item.MembershipTypeId)
                });
            }
            //viewmodel.Customers = uiCustomer;
            return View(uiCustomer);
        }
        public ActionResult Detail(int Id)
        {
            KalliPoshApp.Models.Customers uiCustomer = new Models.Customers();

            var model = _DbContext.Customers.Where(x => x.Id == Id).FirstOrDefault();
            if (model != null)
                uiCustomer.Name = model.Name;
            else
                uiCustomer = null; 
          
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
