using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuitosParaMuitos.Models;

namespace MuitosParaMuitos.Controllers
{
    public class EmpregoTrabalhosController : Controller
    {
        private readonly Contexto _context;

        public EmpregoTrabalhosController(Contexto context)
        {
            _context = context;
        }

        // GET: EmpregoTrabalhos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.EmpregoTrabalhos.Include(e => e.Empregado).Include(e => e.Trabalho);
            return View(await contexto.ToListAsync());
        }

        // GET: EmpregoTrabalhos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregoTrabalho = await _context.EmpregoTrabalhos
                .Include(e => e.Empregado)
                .Include(e => e.Trabalho)
                .FirstOrDefaultAsync(m => m.EmpregadoId == id);
            if (empregoTrabalho == null)
            {
                return NotFound();
            }

            return View(empregoTrabalho);
        }

        // GET: EmpregoTrabalhos/Create
        public IActionResult Create()
        {
            ViewData["EmpregadoId"] = new SelectList(_context.Empregados, "EmpregadoId", "Nome");
            ViewData["TrabalhoId"] = new SelectList(_context.Trabalhos, "TrabalhoId", "Nome");
            return View();
        }

        // POST: EmpregoTrabalhos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpregadoId,TrabalhoId,CargaHoraria")] EmpregoTrabalho empregoTrabalho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empregoTrabalho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpregadoId"] = new SelectList(_context.Empregados, "EmpregadoId", "Nome", empregoTrabalho.EmpregadoId);
            ViewData["TrabalhoId"] = new SelectList(_context.Trabalhos, "TrabalhoId", "Nome", empregoTrabalho.TrabalhoId);
            return View(empregoTrabalho);
        }

        // GET: EmpregoTrabalhos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregoTrabalho = await _context.EmpregoTrabalhos.FindAsync(id);
            if (empregoTrabalho == null)
            {
                return NotFound();
            }
            ViewData["EmpregadoId"] = new SelectList(_context.Empregados, "EmpregadoId", "Nome", empregoTrabalho.EmpregadoId);
            ViewData["TrabalhoId"] = new SelectList(_context.Trabalhos, "TrabalhoId", "Nome", empregoTrabalho.TrabalhoId);
            return View(empregoTrabalho);
        }

        // POST: EmpregoTrabalhos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpregadoId,TrabalhoId,CargaHoraria")] EmpregoTrabalho empregoTrabalho)
        {
            if (id != empregoTrabalho.EmpregadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empregoTrabalho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpregoTrabalhoExists(empregoTrabalho.EmpregadoId))
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
            ViewData["EmpregadoId"] = new SelectList(_context.Empregados, "EmpregadoId", "Nome", empregoTrabalho.EmpregadoId);
            ViewData["TrabalhoId"] = new SelectList(_context.Trabalhos, "TrabalhoId", "Nome", empregoTrabalho.TrabalhoId);
            return View(empregoTrabalho);
        }

        // GET: EmpregoTrabalhos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregoTrabalho = await _context.EmpregoTrabalhos
                .Include(e => e.Empregado)
                .Include(e => e.Trabalho)
                .FirstOrDefaultAsync(m => m.EmpregadoId == id);
            if (empregoTrabalho == null)
            {
                return NotFound();
            }

            return View(empregoTrabalho);
        }

        // POST: EmpregoTrabalhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empregoTrabalho = await _context.EmpregoTrabalhos.FindAsync(id);
            _context.EmpregoTrabalhos.Remove(empregoTrabalho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpregoTrabalhoExists(int id)
        {
            return _context.EmpregoTrabalhos.Any(e => e.EmpregadoId == id);
        }
    }
}
