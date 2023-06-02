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
        public bool Essencial { get; set; }
        public bool isGanho { get; set; }

        public string ToString()
        {
            return Id.ToString() + " " + Name + " " + Cor + " " +  Essencial + " " + isGanho;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Id.GetHashCode();
                hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
                hash = hash * 23 + (Cor != null ? Cor.GetHashCode() : 0);
                hash = hash * 23 + Essencial.GetHashCode();
                hash = hash * 23 + isGanho.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Categoria other = (Categoria)obj;
            return Id == other.Id &&
                   Name == other.Name &&
                   Cor == other.Cor &&
                   Essencial == other.Essencial &&
                   isGanho == other.isGanho;
        }
    }
}
