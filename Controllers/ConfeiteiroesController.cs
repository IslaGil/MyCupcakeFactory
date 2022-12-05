using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCupcakeFactory.Data;
using MyCupcakeFactory.Models;

namespace MyCupcakeFactory.Controllers
{
    public class ConfeiteiroesController : Controller
    {
        private readonly MyCupcakeFactoryContext _context;

        public ConfeiteiroesController(MyCupcakeFactoryContext context)
        {
            _context = context;
        }

        // GET: Confeiteiroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Confeiteiro.ToListAsync());
        }

        // GET: Confeiteiroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var confeiteiro = await _context.Confeiteiro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (confeiteiro == null)
            {
                return NotFound();
            }

            return View(confeiteiro);
        }

        // GET: Confeiteiroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Confeiteiroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Confeiteiro confeiteiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(confeiteiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(confeiteiro);
        }

        // GET: Confeiteiroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var confeiteiro = await _context.Confeiteiro.FindAsync(id);
            if (confeiteiro == null)
            {
                return NotFound();
            }
            return View(confeiteiro);
        }

        // POST: Confeiteiroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Confeiteiro confeiteiro)
        {
            if (id != confeiteiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(confeiteiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfeiteiroExists(confeiteiro.Id))
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
            return View(confeiteiro);
        }

        // GET: Confeiteiroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var confeiteiro = await _context.Confeiteiro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (confeiteiro == null)
            {
                return NotFound();
            }

            return View(confeiteiro);
        }

        // POST: Confeiteiroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var confeiteiro = await _context.Confeiteiro.FindAsync(id);
            _context.Confeiteiro.Remove(confeiteiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfeiteiroExists(int id)
        {
            return _context.Confeiteiro.Any(e => e.Id == id);
        }
    }
}
