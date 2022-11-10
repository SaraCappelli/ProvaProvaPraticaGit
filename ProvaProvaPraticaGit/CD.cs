using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProvaPraticaGit
{
    internal class CD
    {
        internal List<Brano> ListaDeiBrani = new List<Brano>();
        internal string Titolo { get; set; }
        internal string Autore { get; set; }

        internal CD (List<Brano> ListaDeiBrani, string Titolo, string Autore)
        {
            this.ListaDeiBrani = ListaDeiBrani;
            this.Titolo = Titolo;
            this.Autore = Autore;
        }
       
        public override string ToString()
        {
            return Titolo + " di " + Autore;
        }
    }
}
