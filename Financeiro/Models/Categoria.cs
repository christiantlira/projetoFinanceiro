using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cor { get; set; }

        public string ToString()
        {
            return Name;
        }
    }
}
