using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMoedas01.Models;

namespace ProjetoMoedas01.Controllers
{
    public class MoedasController : Controller
    {
        private readonly MoedasContexto _context;

        public MoedasController(MoedasContexto context)
        {
            _context = context;
        }

        // GET: Moedas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Moedas.ToListAsync());
        }

        public async Task<IActionResult> EscolhaVoto(List<Moedas> listaMoedas)
        {
            foreach (var item in listaMoedas)
            {
                if(item.CheckboxPreenchido == true)
                {
                    //Pega a moeda verificando pelo ID
                    Moedas moeda = await _context.Moedas.FirstAsync(m => m.MoedaID == item.MoedaID);
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
        public async Task<IActionResult> Create([Bind("MoedaID,Nome,Quantidade")] Moedas moedas)
        {
            if (ModelState.IsValid)
            {
                //Inicializa com 0
                moedas.Quantidade = 0;
                _context.Add(moedas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moedas);
        }
    }
}
