using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documento
    {
        public int iDurata { get; set; }
        public Dvd(string sCodice, string sTitolo,int iAnno, string sSettore, int iDurata) 
            : base(sCodice,sTitolo,iAnno,sSettore)
        {
            this.iDurata = iDurata;
        }
        public override string ToString()
        {
            return string.Format("{0}\n Durata:{1}",
                base.ToString());
        }
    }
}
