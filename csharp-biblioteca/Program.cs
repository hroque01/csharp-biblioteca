using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DvD gia esistenti
            Dvd dvd1 = new Dvd("D01A", "Iron Man", "2005", "Azione", "D1", "Marvel", "1:45:00");
            Dvd dvd2 = new Dvd("D02B", "Inception", "2010", "Fantascienza", "D2", "Christopher Nolan", "2:28:00");
            Dvd dvd3 = new Dvd("D03C", "Pirati dei Caraibi: La Maledizione del forziere fantasma", "2006", "Avventura", "D3", "Gore Verbinski", "2:31:00");
            Dvd dvd4 = new Dvd("D04D", "The Avengers", "2012", "Azione", "D4", "Marvel", "2:23:00");
            Dvd dvd5 = new Dvd("D02B", "Jurassic Park", "1993", "Fantascienza", "B", "Steven Spielberg", "2:06:00");


            //Libri gia esistenti
            Libri libro1 = new Libri ( "L02B", "Il signore degli anelli","1954","Fantasy", "B","J.R.R. Tolkien","1216" );
            Libri libro2 = new Libri ( "L03C", "Il nome della rosa", "1980", "Giallo", "C", "Umberto Eco", "536" );
            Libri libro3 = new Libri("L04A", "La solitudine dei numeri primi", "2008", "Drammatico", "A", "Paolo Giordano", "296");
            Libri libro4 = new Libri("L05B", "Le città invisibili", "1972", "Romanzo", "B", "Italo Calvino", "165");
            Libri libro5 = new Libri("L06C", "L'isola del giorno prima", "1994", "Romanzo", "C", "Umberto Eco", "360");

            //Registrazione
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.CreateUser();

            //Creazione di un documento
            biblioteca.CreateDocument();
            
        }
    }
}