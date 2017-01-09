using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        string WyszukajPoTytule(string tytul);
        string WyszukajPoId(int id);

    }
}
