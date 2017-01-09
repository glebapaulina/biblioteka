using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Ksiazka: Pozycja
    {
        private int liczbaStron;
        public Autor autor;

        public Ksiazka() { }

        public Ksiazka(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            autor = new Autor(imie, nazwisko);
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
        }
        
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", tytul, id, wydawnictwo, rokWydania, liczbaStron, autor.ToString() );
        }

    }
}
