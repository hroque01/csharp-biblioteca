using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
    {
        public string Codice { get; set; }
        public string Title { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

        public Documenti( string title, string anno, string settore, string scaffale, string autore)
        {
            Codice = GetNumRam();
            Title = title;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            Autore = autore;
        }

        //Metodo per generare numeri random
        public string GetNumRam()
        {
            Random rnd = new Random();
            return rnd.Next(50, 999).ToString();
        }
    }

    class Dvd : Documenti
    {
        public string Durata { get; set; }

        public Dvd(string titolo, string anno, string settore, string scaffale, string autore, string durata) : base(titolo, anno, settore, scaffale, autore)
        {
            Durata = durata;
        }
    }
    
    class Libri : Documenti
    {
        public string Pagine { get; set; }

        public Libri(string titolo, string anno, string settore, string scaffale, string autore, string pagine) : base(titolo, anno, settore, scaffale, autore)
        {
            Pagine = pagine;
        }
    }

}
