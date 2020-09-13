using FaixaEtaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaixaEtaria.ViewComponents
{
    public class AdolescenteViewComponent : ViewComponent
    {
        private readonly PessoaContexto _pessoaContexto;

        public AdolescenteViewComponent(PessoaContexto pessoaContexto)
        {
            _pessoaContexto = pessoaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _pessoaContexto.Pessoas.Where(x => x.Idade < 18).ToListAsync());
        }
    }
}
