using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito : Stato
    {
        public string sNumero { get; set; }
        public DateTime dtDal { get; set; }
        public DateTime dtAl { get; set; }
        public Utente cUtente { get; set; }
        public Documento cDocumento { get; set; }

        public Prestito(string sNumero, DateTime dtDal, DateTime dtAl, Utente cUtente, Documento cDocumento,bool bDisponibile) : base(bDisponibile)
        {
            this.sNumero = sNumero;
            this.dtDal = dtDal;
            this.dtAl = dtAl;
            this.cUtente = cUtente;
            this.cDocumento = cDocumento;
        }

        public override string ToString()
        {
            return string.Format("Numero:{0}\nDal:{1}\nAl:{2}\nStato:{3}\nUtente:\n{4}\nDocumento:\n{5}\n{6}",
                this.sNumero,
                this.dtDal,
                this.dtAl,
                this.cUtente,
                this.cDocumento,
                base.ToString());
        }
    }
}
