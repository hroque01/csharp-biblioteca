using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Registrazione
            Biblioteca biblioteca = new Biblioteca();
            //biblioteca.CreateUser();

            ////Creazione di un documento
            //biblioteca.CreateDocument();

            biblioteca.PrestitoDocumento();
            
        }
    }
}