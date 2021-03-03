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
        private readonly ApplicationDbContext _context;
        public RentailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet]
        public List<Carreg> Getcar()
        {
            var cars = _context.Carreg.ToList();
            return cars;
        }

        [HttpPost]
        public List<Customer> Getid(int id)
        {
            var customer = (from s in _context.Customer where s.id == id select s.custname).ToList();
            return customer; 
        }
    }
}
