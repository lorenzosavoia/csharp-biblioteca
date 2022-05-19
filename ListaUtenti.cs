using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ListaUtenti
    {
        //creiamo un dizionario di utenti usando 3 stringhe nome, cognome, email per creare la chiave
        private Dictionary<Tuple<string, string, string>, Utente> MyDictionary;
        public ListaUtenti()
        {
            MyDictionary = new Dictionary<Tuple<string, string, string>, Utente>();
        }
        //creo una funzione passandogli la classe utente per poterla usare dentro
        //lachiave la creo io 
        public void AggiungiUtente(Utente cMioUtente)
        {
            //dico che la mia chiave corrisponde ai seguenti vaolori
            var chiave = new Tuple<string, string, string>(cMioUtente.sNome, cMioUtente.sCognome, cMioUtente.sEmail);
            //aggiungo la key e i dati del mio utente al dizionario di utenti
            MyDictionary.Add(chiave, cMioUtente);
        }
    }
}
