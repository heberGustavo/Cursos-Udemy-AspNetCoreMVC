using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoDeDados.Models
{
    public class Tarefas
    {
        [Key]
        public int TarefaId { get; set; }

        [Remote("UsuarioExisteAsync", "Tarefas")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(25, ErrorMessage = "Tamanho maximo atingido!")]
        public string Nome { get; set; }

        //Limite de numeros
        //[Range(1,90, ErrorMessage = "Digite valor entre 1 e 90")]

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(50, ErrorMessage = "Tamanho maximo atingido!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.DateTime)]
        public DateTime Inicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.DateTime)]
        [Compare("Inicio")]
        public DateTime Fim { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(10, ErrorMessage = "Tamanho maximo atingido!")]
        public string Importancia { get; set; }

    }
}
