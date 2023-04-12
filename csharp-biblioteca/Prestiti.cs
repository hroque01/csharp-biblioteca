using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public Utenti Utente { get; set; }
        public Documenti Documento { get; set; }
        public string dataInizio { get; set; }
        public string dataFine { get; set; }

        public Prestito(Utenti utente, Documenti documento, string dataInizio, string dataFine)
        {
            Utente = utente;
            Documento = documento;
            this.dataInizio = dataInizio;
            this.dataFine = dataFine;
        }
    }
}
