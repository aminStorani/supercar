using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using supercar.Data;
using supercar.Models;

namespace supercar.Controllers
{
    public class CarregsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarregsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carregs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carreg.ToListAsync());
        }

        // GET: Carregs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carreg
                .FirstOrDefaultAsync(m => m.id == id);
            if (carreg == null)
            {
                return NotFound();
            }

            return View(carreg);
        }

        // GET: Carregs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carregs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,carno,make,model,available")] Carreg carreg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carreg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carreg);
        }

        // GET: Carregs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carreg.FindAsync(id);
            if (carreg == null)
            {
                return NotFound();
            }
            return View(carreg);
        }

        // POST: Carregs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,carno,make,model,available")] Carreg carreg)
        {
            if (id != carreg.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carreg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarregExists(carreg.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carreg);
        }

        // GET: Carregs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carreg = await _context.Carreg
                .FirstOrDefaultAsync(m => m.id == id);
            if (carreg == null)
            {
                return NotFound();
            }

            return View(carreg);
        }

        // POST: Carregs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carreg = await _context.Carreg.FindAsync(id);
            _context.Carreg.Remove(carreg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarregExists(int id)
        {
            return _context.Carreg.Any(e => e.id == id);
        }
    }
}
