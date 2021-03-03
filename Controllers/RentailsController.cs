using Microsoft.AspNetCore.Mvc;
using supercar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace supercar.Controllers
{
    public class RentailsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Getcar()
        {
            var car = db.Carreg.ToList();
            return View(car);
        }
    }
}
