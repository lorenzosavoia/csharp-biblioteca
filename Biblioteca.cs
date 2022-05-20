using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public string sNome { get; set; }
        public List<Documento> lsDocumenti { get; set; }
        public List<Prestito> lsPrestiti { get; set; }
        public List<Utente> lsUtenti { get; set; }
        public List<ListaUtenti> lsListaUtenti { get; set; }

        //dichiaro solo il nome le liste le istanzio e basta
        public Biblioteca(string sNome)
        {
            this.sNome = sNome;
            //se dichiaro cosi senza parentesi instanzio le liste senza doverle riempire con qualcosa nell'immediato
            //popolo dopo attraverso ad un add
            this.lsDocumenti = new List<Documento>();
            this.lsPrestiti = new List<Prestito>();
            this.lsUtenti = new List<Utente>();
        }
        public bool RestoreUtenti(string sFileName)
        {
            StreamReader sr = new StreamReader(sFileName);
            string sFileVero = sr.ReadLine();
            sr.Close();
            string sRiga;
            List<Utente> lsUtenti = new List<Utente>();
            while((sRiga = sr.ReadLine()) != null)
            {
                string[] vString = sRiga.Split(";");
                string sNome = vString[0];
                string sCognome = vString[1];
                string sTelefono = vString[2];
                string sEmail = vString[3];
                string sPassword = vString[4];

                Utente utente = new Utente(sNome, sCognome, sTelefono, sEmail, sPassword);
                lsUtenti.Add(utente);
            }
            return true;

        }
    }
}
