using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agili.Food.ViewModels.Cardapio
{
    public class CardapioViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Fornecedor")]
        [Required(ErrorMessage = "Nome do Fornecedor é Obrigatorio")]
        public string NomeFornecedor { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "Você deve colocar o nome do produto a ser Cadastrado")]
        public string NomePedido { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Coloque o valor a ser cobrado ")]
        public float Valor { get; set; }

        [Required(ErrorMessage = "Você deve dizer qual o tipo do produto")]
        public string Tipo { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime DataCad { get; set; }
    }
}