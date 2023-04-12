using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestiti
    {
        public Utenti Utenti { get; set; }
        public Documenti Documenti { get; set; }
        public string dataInizio { get; set; }
        public string dataFine { get; set; }
    }
}
