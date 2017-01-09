using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Czasopismo: Pozycja
    {
        private int numer;

        public Czasopismo() { }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", tytul, id, wydawnictwo, rokWydania, numer );
        }
    }
}
