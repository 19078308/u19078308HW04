using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19078308HW04.Models;

namespace u19078308HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our mission and Our focus";

            return View();
        }
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Donate()
        {
            List<Individuals> donors = GetDonorData();
            return View(donors);
        }
        private List<Individuals> GetDonorData()
        {
            List<Individuals> donors = new List<Individuals>();
            Individuals donor1 = new Individuals("Adila Lekau", 0823548756, "2022/08/22", 2000, true );
            
            donors.Add(donor1);
            
            return donors;
        }
        // Get members lists
        public ActionResult Members()
        {
            List<Organisations> organisations = GetData();
            return View(organisations);
        }
        private List<Organisations> GetData()
        {
            List<Organisations> organisations = new List<Organisations>();
            Organisations organisations1 = new Organisations("Tshepo Mononyane", 0762444724, "2022/08/18", 100000.00, "Founder", true);
            Organisations organisations2 = new Organisations("Zandile Holdings", 0609512344, "2022/08/18", 25000.00, "SmallHolder Farmers", true);

            organisations.Add(organisations1);
            organisations.Add(organisations2);

            return organisations;
        }

    }
}