using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiniMundo.Data;
using MiniMundo.Models;

namespace MiniMundo.Controllers
{
    public class NivelAcessosController : Controller
    {
        private readonly MiniMundoContext _context;

        public NivelAcessosController(MiniMundoContext context)
        {
            _context = context;
        }

        // GET: NivelAcessos
        public async Task<IActionResult> Index()
        {
            return View(await _context.NivelAcesso.ToListAsync());
        }

        // GET: NivelAcessos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso
                .FirstOrDefaultAsync(m => m.NivelID == id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }

            return View(nivelAcesso);
        }

        // GET: NivelAcessos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NivelAcessos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NivelID,CategoriaAcesso")] NivelAcesso nivelAcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivelAcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nivelAcesso);
        }

        // GET: NivelAcessos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso.FindAsync(id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }
            return View(nivelAcesso);
        }

        // POST: NivelAcessos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NivelID,CategoriaAcesso")] NivelAcesso nivelAcesso)
        {
            if (id != nivelAcesso.NivelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivelAcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelAcessoExists(nivelAcesso.NivelID))
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
            return View(nivelAcesso);
        }

        // GET: NivelAcessos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelAcesso = await _context.NivelAcesso
                .FirstOrDefaultAsync(m => m.NivelID == id);
            if (nivelAcesso == null)
            {
                return NotFound();
            }

            return View(nivelAcesso);
        }

        // POST: NivelAcessos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivelAcesso = await _context.NivelAcesso.FindAsync(id);
            if (nivelAcesso != null)
            {
                _context.NivelAcesso.Remove(nivelAcesso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelAcessoExists(int id)
        {
            return _context.NivelAcesso.Any(e => e.NivelID == id);
        }
    }
}
