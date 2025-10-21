using Microsoft.AspNetCore.Mvc;
using tryagain.Models;

namespace tryagain.Controllers
{
    public class MyTax : Controller
    {
        public IActionResult Index()
        {
            return View(new Tax());
        }

        [HttpPost]
        public IActionResult Index(Tax s)
        {
            if (s.TaxId == "NG" && s.Sal >= 500000)
            {
                s.Ta = s.Sal * 19 / 100;
            }
            else if(s.TaxId == "NG" && s.Sal >= 1600000)
            {
                s.Ta = s.Sal * 21 / 100;
            }
            else
            {
                s.Ta = s.Sal * 1 / 100;
            }
            return View();
        }
    }
}
