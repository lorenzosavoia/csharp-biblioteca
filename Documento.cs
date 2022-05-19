using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        public string sCodice { get; set; }
        public string sTitolo { get; set; }
        public int iAnno { get; set; }
        public string sSettore { get; set; }
        public List<Autore> sAutore { get; set; }
        public Scaffale Scaffale { get; set; }
        public Stato cStato { get; set; }

        public Documento(string sCodice, string sTitolo, int iAnno, string sSettore)
        {
            this.sCodice = sCodice;
            this.sTitolo = sTitolo;
            this.iAnno = iAnno;
            this.sSettore = sSettore;
            this.sAutore = new List<Autore>();
            this.cStato = cStato;
        }
        /*
        public override string ToString()
        {
            return string.Format("Codice:{ 0}\nTitolo: {1}\nAnno: {2}\nSettore:{3}\n Scaffale Numero{4}:",
                this.sCodice,
                this.sTitolo,
                this.iAnno,
                this.sSettore,
                this.Scaffale.sNumero);


        }
        */

        public override string ToString()
        {
            return string.Format("Codice:{0}\nTitolo:{1}\nSettore:{2}\nStato:{3}\nScaffale numero:{4}",
                this.sCodice,
                this.sTitolo,
                this.sSettore,
                this.cStato,
                this.Scaffale.sNumero);
        }
    }

}
