using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    class Stat
    {
        int ev, versenyek, gyozelmek, podiumok, elsohely, leggyorsabb;

        public int Ev { get => ev; set => ev = value; }
        public int Versenyek { get => versenyek; set => versenyek = value; }
        public int Gyozelmek { get => gyozelmek; set => gyozelmek = value; }
        public int Podiumok { get => podiumok; set => podiumok = value; }
        public int Elsohely { get => elsohely; set => elsohely = value; }
        public int Leggyorsabb { get => leggyorsabb; set => leggyorsabb = value; }

        public Stat(int ev, int versenyek, int gyozelmek, int podiumok, int elsohely, int leggyorsabb)
        {
            Ev = ev;
            Versenyek = versenyek;
            Gyozelmek = gyozelmek;
            Podiumok = podiumok;
            Elsohely = elsohely;
            Leggyorsabb = leggyorsabb;
        }

        public Stat(string adatsor)
        {
            string[] adatok = adatsor.Split('\t');
            Ev = int.Parse(adatok[0]);
            Versenyek = int.Parse(adatok[1]);
            Gyozelmek = int.Parse(adatok[2]);
            Podiumok = int.Parse(adatok[3]);
            Elsohely = int.Parse(adatok[4]);
            Leggyorsabb = int.Parse(adatok[5]);
        }
    }
}
