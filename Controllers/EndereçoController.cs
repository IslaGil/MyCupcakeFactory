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
    public class EndereçoController : Controller
    {
        private readonly MyCupcakeFactoryContext _context;

        public EndereçoController(MyCupcakeFactoryContext context)
        {
            _context = context;
        }

        // GET: Endereço
        public async Task<IActionResult> Index()
        {
            return View(await _context.Endereço.ToListAsync());
        }

        // GET: Endereço/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereço = await _context.Endereço
                .FirstOrDefaultAsync(m => m.Id == id);
            if (endereço == null)
            {
                return NotFound();
            }

            return View(endereço);
        }

        // GET: Endereço/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Endereço/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CEP,Bairro,Cidade,Numero,Complemento")] Endereço endereço)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endereço);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(endereço);
        }

        // GET: Endereço/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereço = await _context.Endereço.FindAsync(id);
            if (endereço == null)
            {
                return NotFound();
            }
            return View(endereço);
        }

        // POST: Endereço/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CEP,Bairro,Cidade,Numero,Complemento")] Endereço endereço)
        {
            if (id != endereço.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endereço);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EndereçoExists(endereço.Id))
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
            return View(endereço);
        }

        // GET: Endereço/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereço = await _context.Endereço
                .FirstOrDefaultAsync(m => m.Id == id);
            if (endereço == null)
            {
                return NotFound();
            }

            return View(endereço);
        }

        // POST: Endereço/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var endereço = await _context.Endereço.FindAsync(id);
            _context.Endereço.Remove(endereço);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EndereçoExists(int id)
        {
            return _context.Endereço.Any(e => e.Id == id);
        }
    }
}
