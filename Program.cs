using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csharp_biblioteca // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gestione file di configurazione
            string vPublicEnv = Environment.GetEnvironmentVariable("PUBLIC");
            if (vPublicEnv != null)
            {
                Console.WriteLine("valore: {0}",vPublicEnv);
            }  
            if (Directory.Exists(vPublicEnv + "\\Biblioteca"))
            {
                Console.WriteLine("la directory é giá esistente");

                if (File.Exists(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt"))
                {
                    Console.WriteLine("il file .txt esiste giá");
                }
                else
                {
                    Console.WriteLine("Immetti percorso file oppure premi invio");
                    string sFileTxt = Console.ReadLine();
                    if (sFileTxt == "")
                    {
                        StreamWriter sw = new StreamWriter(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                        sw.Write("section:fileConfig;");
                        sw.Write(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                        Console.WriteLine("il file .txt é stato creato");
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                        sw.Write("section:fileConfig;");
                        sw.Write(sFileTxt);
                        Console.WriteLine("il file .txt é stato creato.");
                        sw.Close ();
                    }

                }
            }
            else
            {
                Console.WriteLine("la cartella non esiste crearla ora? S/N");
                string choise = Console.ReadLine();
                switch(choise)
                {
                    case "s":
                        {
                            Directory.CreateDirectory(vPublicEnv + "\\Biblioteca");
                            Console.WriteLine("la directory Biblioteca é stata creata");
                            Console.WriteLine("Immetti percorso file oppure premi invio");
                            string sFileTxt = Console.ReadLine();
                            if (sFileTxt == "")
                            {
                                StreamWriter sw = new StreamWriter(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                                sw.Write("section:fileConfig;");
                                sw.Write(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                                Console.WriteLine("il file .txt é stato creato");
                                sw.Close();
                            }
                            else
                            {
                                StreamWriter sw = new StreamWriter(vPublicEnv + "\\Biblioteca" + "\\biblioteca.txt");
                                sw.Write("section:fileConfig;");
                                sw.Write(sFileTxt);
                                Console.WriteLine("il file .txt é stato creato.");
                                sw.Close();
                            }
                        }
                        break;
                    case "n":
                        {
                            Console.WriteLine("la cartella non é stata creata");
                            
                        }
                        break;
                }  
            }
            
            Biblioteca Belgioioso = new Biblioteca("Biblioteca comunale");
            
            Scaffale s1 = new Scaffale("1");
            Autore autore1 = new Autore("dante", "palle");
            Libro doc1 = new Libro("123123", "ciao sono il titolo", 2021, "geografia",142);
            
            doc1.sAutore.Add(autore1);
            doc1.Scaffale = s1;
            //Console.WriteLine(doc1.ToString());

            //dichiaro lista da compilare col readline
            List<string> lsUtentiSR = new List<string>();
            //vado a popolare la lista con i file precendentemente salvati su un file
            //adotto un try chatch per gli errori
            try
            {
                if (File.Exists(vPublicEnv + "\\Biblioteca" + "\\biblioteca-utenti.txt"))
                {
                    string sRiga;
                    using (StreamReader sr = new StreamReader(vPublicEnv + "\\Biblioteca" + "\\biblioteca-utenti.txt"))
                    {
                        while ((sRiga = sr.ReadLine()) != null)
                        {
                            lsUtentiSR.Add(sRiga);
                        }
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            //dichiaro la variabile per il ciclo while
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
                            string sNome = Console.ReadLine();
                            Console.WriteLine("inserisci cognome");
                            string sCognome = Console.ReadLine();
                            Console.WriteLine("inserisci telefono");
                            string sTelefono = Console.ReadLine();
                            Console.WriteLine("inserisci Email");
                            string sEmail = Console.ReadLine();
                            Console.WriteLine("inserisci Password");
                            string sPassword = Console.ReadLine();

                            Belgioioso.lsUtenti.Add(new Utente(sNome, sCognome, sTelefono, sEmail, sPassword));
                        }
                        break;
                        case "2":
                        {
                            Console.WriteLine("Utenti registrati in questa sessione:");
                            foreach(Utente Utente in Belgioioso.lsUtenti)
                            {
                                Console.WriteLine(Utente.ToString());
                            }
                            
                            Console.WriteLine("Utenti registrati in precedenza:");
                            foreach (string utente in lsUtentiSR)
                            {
                                Console.WriteLine(utente);
                            }
                        }
                        break;
                        case "9":
                        {
                            StreamWriter sm = new StreamWriter(vPublicEnv + "\\Biblioteca" + "\\biblioteca-utenti.txt");
                            foreach(Utente utente in Belgioioso.lsUtenti)
                            {
                                sm.WriteLine(utente.ToString());
                            }
                            sm.Close();
                            Environment.Exit(0);
                            bFinito = true;
                        }
                        break;
                }
            }
        }
    }
}