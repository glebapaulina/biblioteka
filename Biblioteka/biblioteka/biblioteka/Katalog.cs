using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    class Katalog: IZarzadzanieKatalogiem
    {
        List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog() { }

        public void dodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }

        public void dodajPozycje(string imie, string nazwisko, string tytul, int id, string  wydawnictwo, int rokWydania, int liczbaStron)
        {

            listaPozycji.Add(new Ksiazka(imie, nazwisko, tytul, id, wydawnictwo, rokWydania, liczbaStron));
        }

        public void dodajPozycje(string tytul, string wydawnictwo, int rokWydania, int id, int numer)
        {
            listaPozycji.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        public string WyszukajPoTytule(string tytul)
        {
            string result = "";
            List<Pozycja> wysz = listaPozycji.FindAll(x => x.GetTytul() == tytul);
            foreach (var element in wysz)
            {
                result += element.ToString();
            }
            return result;
        }

    }
}
