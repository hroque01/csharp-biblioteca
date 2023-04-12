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
    }
}
