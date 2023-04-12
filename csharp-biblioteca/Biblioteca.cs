using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        private List<Documenti> Documenti = new List<Documenti>();
        private List<Utenti> Utenti = new List<Utenti>();
        private List<Prestiti> Prestiti = new List<Prestiti>();

        public Utenti createUser()
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

        public void createDocument()
        {
            Console.WriteLine("Inserisci i dati del nuovo documento:");

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

        public void AggiungiPrestito(Utenti utente, Documenti documento, string dataInizio, string dataFine)
        {
            Prestiti nuovoPrestito = new Prestiti { Utenti = utente, Documenti = documento, dataInizio = dataInizio, dataFine = dataFine };
            Prestiti.Add(nuovoPrestito);
        }
    }
}
