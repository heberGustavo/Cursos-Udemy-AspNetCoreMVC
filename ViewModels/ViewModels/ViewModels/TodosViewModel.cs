using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class TodosViewModel
    {
        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<Materia> Materias { get; set; }
    }
}
