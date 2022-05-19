using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Stato
    {
        public bool bDisponilibe { get; set; }

        public Stato(bool bDisponibile)
        {
            this.bDisponilibe = bDisponilibe;
        }
        public override string ToString()
        {
            return string.Format("Disponibilitá:{0}", bDisponilibe);
        }
        public bool GetStato()
        {
            return this.bDisponilibe;
        }
    }
}
