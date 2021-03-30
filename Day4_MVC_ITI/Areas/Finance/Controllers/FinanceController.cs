using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4_MVC_ITI.Areas.Finance.Controllers
{
    public class FinanceController : Controller
    {
        // GET: Finance/Finance
        public ActionResult Index()
        {
            return View();
        }
    }
}