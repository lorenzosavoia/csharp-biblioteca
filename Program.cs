using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca Belgioioso = new Biblioteca("Biblioteca comunale");
            Scaffale s1 = new Scaffale("1");
            Autore autore1 = new Autore("dante", "palle");
            Libro doc1 = new Libro("123123", "ciao sono il titolo", 2021, "geografia",142);
            
            doc1.sAutore.Add(autore1);
            doc1.Scaffale = s1;
            Console.WriteLine(doc1.ToString());

            string sCodice; string sTitolo; int iAnno; string sSettore;
            //variabili per utenti
            string sNome; string sCognome; string sTelefono; string sPassword;string sEmail;
            bool bFinito = false;
            
            while(!bFinito)
            {
                Console.WriteLine("1-Aggiungi Utente 2-Stampa lista utenti 9- Esci dall'app");
                string cmd = Console.ReadLine();
                switch(cmd)
                {
                    case "1":
                        {
                            Console.WriteLine("inserisci nome");
                            sNome = Console.ReadLine();
                            Console.WriteLine("inserisci cognome");
                            sCognome = Console.ReadLine();
                            Console.WriteLine("inserisci telefono");
                            sTelefono = Console.ReadLine();
                            Console.WriteLine("inserisci Email");
                            sEmail = Console.ReadLine();
                            Console.WriteLine("inserisci Password");
                            sPassword = Console.ReadLine();

                            Belgioioso.lsUtenti.Add(new Utente(sNome, sCognome, sTelefono, sEmail, sPassword));
                        }
                        break;
                        case "2":
                        {
                            foreach(Utente Utente in Belgioioso.lsUtenti)
                            {
                                Console.WriteLine(Utente.ToString());
                            }
                        }
                        break;
                        case "9":
                        {
                            StreamWriter sm = new StreamWriter("Utenti-bliblioteca.txt");
                            foreach(Utente utente in Belgioioso.lsUtenti)
                            {
                                string new_string = utente.sNome + ";" + utente.sCognome + ";" + utente.sTelefono + ";" + utente.sEmail;
                                sm.WriteLine(new_string);
                            }
                            sm.Close();
                            bFinito = true;
                        }
                        break;
                }
            }
        }
    }
}