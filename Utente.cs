using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente : Persona
    {
        public string sTelefono { get; set; }

        public string sEmail { get; set; }
        public string sPassword { get; set; }

        public Utente(string sNome, string sCognome, string sTelefono, string sEmail, string sPassword) : base(sNome, sCognome)
        {
            this.sTelefono = sTelefono;
            this.sEmail = sEmail;
            this.sPassword = sPassword;
        }
        //classe con la finalitá di stampare persona ereditando da utente
        public override string ToString()
        {
            return string.Format("{0}\n Telefono:{1}\n Email:{2}\n Password{3}",
                                base.ToString(),
                                this.sTelefono,
                                this.sEmail,
                                this.sPassword);
        }
        
    }
}
