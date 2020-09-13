using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMoeda02.Models;

namespace ProjetoMoeda02.Controllers
{
    public class MoedasController : Controller
    {
        private readonly MoedaContexto _context;

        public MoedasController(MoedaContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Moedas.ToListAsync());
        }

        public async Task<IActionResult> EscolhaDeMoeda(List<Moedas> listaDeMoedas)
        {
            foreach (var item in listaDeMoedas)
            {
                if (item.Checkbox == true)
                {
                    Moedas moeda = await _context.Moedas.FirstAsync(m => m.MoedasId == item.MoedasId);
                    moeda.Quantidade++;
                    _context.Update(moeda);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoedasId,Nome,Quantidade")] Moedas moedas)
        {
            if (ModelState.IsValid)
            {
                moedas.Quantidade = 0;
                _context.Add(moedas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moedas);
        }
    }
}
