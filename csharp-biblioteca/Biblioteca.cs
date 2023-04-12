using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        private List<Documenti> Documenti = new List<Documenti>();

        public Biblioteca()
        {
            AggiungiDocumenti();
        }

        private void AggiungiDocumenti()
        {
            //DvD gia esistenti
            Dvd dvd1 = new Dvd("D01A", "Iron Man", "2005", "Azione", "D1", "Marvel", "1:45:00");
            Dvd dvd2 = new Dvd("D02B", "Inception", "2010", "Fantascienza", "D2", "Christopher Nolan", "2:28:00");
            Dvd dvd3 = new Dvd("D03C", "Pirati dei Caraibi: La Maledizione del forziere fantasma", "2006", "Avventura", "D3", "Gore Verbinski", "2:31:00");
            Dvd dvd4 = new Dvd("D04D", "The Avengers", "2012", "Azione", "D4", "Marvel", "2:23:00");
            Dvd dvd5 = new Dvd("D02B", "Jurassic Park", "1993", "Fantascienza", "B", "Steven Spielberg", "2:06:00");


            //Libri gia esistenti
            Libri libro1 = new Libri("L02B", "Il signore degli anelli", "1954", "Fantasy", "B", "J.R.R. Tolkien", "1216");
            Libri libro2 = new Libri("L03C", "Il nome della rosa", "1980", "Giallo", "C", "Umberto Eco", "536");
            Libri libro3 = new Libri("L04A", "La solitudine dei numeri primi", "2008", "Drammatico", "A", "Paolo Giordano", "296");
            Libri libro4 = new Libri("L05B", "Le città invisibili", "1972", "Romanzo", "B", "Italo Calvino", "165");
            Libri libro5 = new Libri("L06C", "L'isola del giorno prima", "1994", "Romanzo", "C", "Umberto Eco", "360");

            Documenti.Add(dvd1);
            Documenti.Add(dvd2);
            Documenti.Add(dvd3);
            Documenti.Add(dvd4);
            Documenti.Add(dvd5);
            Documenti.Add(libro1);
            Documenti.Add(libro2);
            Documenti.Add(libro3);
            Documenti.Add(libro4);
            Documenti.Add(libro5);
        }

        private List<Utenti> Utenti = new List<Utenti>();
        private List<Prestiti> Prestiti = new List<Prestiti>();

        

       

        public Utenti CreateUser()
        {
            Console.Write("Registrati!");

            //Cognome
            Console.Write("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();

            //Nome
            Console.Write("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();


            //Cognome
            Console.Write("Inserisci il tuo email: ");
            string email = Console.ReadLine();

            //Password
            Console.Write("Inserisci la tua password: ");
            string utentePassword = Console.ReadLine();

            //Telefono
            Console.Write("Inserisci il tuo numero di telefono: ");
            string telefono = Console.ReadLine();

            Utenti nuovoUtente = new Utenti(cognome, nome, email, utentePassword, telefono);

            Console.WriteLine($"Cognome: {nuovoUtente.Cognome} \n " +
                    $"Nome: {nuovoUtente.Nome} \n " +
                    $"Email: {nuovoUtente.Email} \n " +
                    $"Password: {nuovoUtente.UtentePassword} \n " +
                    $"Telefono: {nuovoUtente.Telefono}"
                    );

            Utenti.Add(nuovoUtente);

            return nuovoUtente;
        }

        public void CreateDocument()
        {
            Console.WriteLine();
            Console.WriteLine("Vuoi aggiungere un DVD o un libro nuovo?");
            string risposta = Console.ReadLine();
            if (risposta == "si") {
                Console.Write("Codice: ");
                string codice = Console.ReadLine();

                Console.Write("Titolo: ");
                string titolo = Console.ReadLine();

                Console.Write("Anno di pubblicazione: ");
                string anno = Console.ReadLine();

                Console.Write("Settore: ");
                string settore = Console.ReadLine();

                Console.Write("Scaffale: ");
                string scaffale = Console.ReadLine();

                Console.Write("Autore: ");
                string autore = Console.ReadLine();

                Console.Write("Tipo di documento (dvd/libro): ");
                string tipo = Console.ReadLine();

                if (tipo == "dvd")
                {
                    Console.Write("Durata: ");
                    string durata = Console.ReadLine();
                    Documenti nuovoDocumento = new Dvd(codice, titolo, anno, settore, scaffale, autore, durata);
                    Documenti.Add(nuovoDocumento);
                }
                else if (tipo == "libro")
                {
                    Console.Write("Numero di pagine: ");
                    string pagine = Console.ReadLine();
                    Documenti nuovoDocumento = new Libri(codice, titolo, anno, settore, scaffale, autore, pagine);
                    Documenti.Add(nuovoDocumento);
                }
            }
             else
            {
                Console.WriteLine("Grazie Arrivederci!");
            }

            
        }

        public void PrestitoDocumento()
        {


            Console.WriteLine("Vuoi cercare tramite codice o titolo?");
            string ricerca = Console.ReadLine();
            ricerca = ricerca.ToLower();
            
            if (ricerca == "codice")
            {
                Console.WriteLine("Inserisci il codice");
                string codiceRicerca = Console.ReadLine();
                Documenti.FindAll(Documenti => Documenti.Codice == codiceRicerca);

                if (Documenti.Find(doc => doc.Codice == codiceRicerca) != null)
                {
                    Console.WriteLine("Prestito eseguito correttamente");
                    // Qui puoi aggiungere il codice per gestire il prestito del documento
                }
                else
                {
                    Console.WriteLine("Documento non trovato!");
                }


            }

            if ( ricerca == "titolo")
            {
                Console.WriteLine("Inserisci il titolo");
                string titoloRicerca = Console.ReadLine();
                Documenti.FindAll(Documenti => Documenti.Titolo == titoloRicerca);

                if (Documenti.Find(doc => doc.Titolo == titoloRicerca) != null)
                {
                    Console.WriteLine("Prestito eseguito correttamente");
                    // Qui puoi aggiungere il codice per gestire il prestito del documento
                }
                else
                {
                    Console.WriteLine("Documento non trovato!");
                }
            }

        }


    }
}
