using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMoeda02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoeda02.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedaContexto _moedaContexto;

        public MoedasViewComponent(MoedaContexto moedaContexto)
        {
            _moedaContexto = moedaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _moedaContexto.Moedas.ToListAsync());
        }
    }
}
