using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agili.Food.ViewModels.Cardapio
{
    public class CardapioIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Fornecedor")]
        public string NomeFornecedor { get; set; }

        [Display(Name = "Produto")]
        public string NomePedido { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public float Valor { get; set; }

        public string Tipo { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        public DateTime DataCad { get; set; }
    }
}