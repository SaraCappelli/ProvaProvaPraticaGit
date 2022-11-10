using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Patrick Battzza 4E 10-11-2022

namespace ProvaProvaPraticaGit
{
    internal class Brano
    {
        internal string Titolo { get; set; }
        internal string Autore { get; set; }
        internal int Durata { get; set; } //in secondi

        //accetta i dati inseriti in input durante la creazione dell'oggetto
        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        //restituisce una stringa con gli attributi del brano
        public string toString()
        {
            return Titolo.ToString() + ", " + Autore.ToString() + ", " + Durata.ToString() + ".";
        }

        //la variabile bool va pre settata a false
        public bool ShortSong(int durataScelta)
        {
            if (Durata < durataScelta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
