using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMoedas01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoedas01.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedasContexto _moedaContexto;

        public MoedasViewComponent(MoedasContexto moedasContexto)
        {
            _moedaContexto = moedasContexto;
        }

        //Retorna todos os elementos
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _moedaContexto.Moedas.ToListAsync());
        }
    }
}
