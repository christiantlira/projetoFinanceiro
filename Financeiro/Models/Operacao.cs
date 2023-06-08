using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models
{
    public class Operacao
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public bool Ganho { get; set; }
    }
}
