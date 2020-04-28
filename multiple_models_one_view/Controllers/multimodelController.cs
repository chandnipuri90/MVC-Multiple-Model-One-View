using multiple_models_one_view.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace multiple_models_one_view.Controllers
{
    public class multimodelController : Controller
    {
        private db_context db = new db_context();




        // GET: multimodel
        public async Task<ActionResult> Index()
        {
            return View();

        }

        public Customer Getcustomer(int? id)
        {

            Customer customer = db.Customers.Where(s => s.Id == id).FirstOrDefault();
            return customer;
        }

        public login Getlogin(int? id)
        {

            login _login = db.logins.Where(s => s.login_id == id).FirstOrDefault();
            return _login;

        }
        public ActionResult abc()
        {
            ViewModel vm = new ViewModel();
            vm.customermodel = Getcustomer(2);
            vm.loginmodel = Getlogin(2);
            return View(vm);
        }
       
        //    public Customer Getcustomer()
        //    {
        //        Customer cmodel = new Customer()
        //        {

        //            Id = 1,
        //            FirstName = "Chandni",
        //            LastName = "PuriChopra",
        //            Email = "chandni.puri434.gmail.com"

        //        };

        //        return cmodel;
        //    }


        //    public login Getlogin()
        //    {
        //        login lmodel = new login()
        //        {
        //            login_id = 1,
        //            username = "Harish",
        //            Usertype = "Admin"
        //        };

        //        return lmodel;
        //    }
        //}
    }
}