using System.Security.Cryptography.X509Certificates;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
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


        }
    }
}