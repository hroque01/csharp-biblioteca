using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utenti
    {
        public string Cognome { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string UtentePassword { get; set; }

        public string Telefono { get; set; }

        public Utenti(string cognome, string nome, string email, string utentePassword, string telefono)
        {
            Cognome = cognome;
            Nome = nome;
            Email = email;
            UtentePassword = utentePassword;
            Telefono = telefono;
        }
    }
}
