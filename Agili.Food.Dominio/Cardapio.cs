using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agili.Food.Dominio
{
    public class Cardapio
    {
        public int Id { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomePedido { get; set; }
        public string Tipo { get; set; }
        public float Valor { get; set; }
        public DateTime DataCad { get; set; }
    }
}
