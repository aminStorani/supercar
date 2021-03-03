using Microsoft.AspNetCore.Mvc;
using supercar.Data;
using supercar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace supercar.Controllers
{
    public class RentailsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        private readonly ApplicationDbContext _context;



        public RentailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Carreg> Getcar()
        {
            var cars = _context.Carreg.ToList();
            return cars;
        }
    }
}
