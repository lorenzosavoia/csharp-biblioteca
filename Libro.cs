using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
        public int iNumeroPagine { get; set; }
        public Libro(string sCodice, string sTitolo,int iAnno, string sSettore,int iNumeroPagine) : base(sCodice,sTitolo,iAnno,sSettore)
        {
            this.iNumeroPagine = iNumeroPagine;
        }
        public override string ToString()
        {
            return string.Format("{0}\nNumero pagine:{1}",
                                base.ToString(),
                                this.iNumeroPagine);
        }
    }
}
