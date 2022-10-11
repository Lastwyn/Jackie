using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackie
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Stat> adatok = new List<Stat>();
            
            using (StreamReader file = new StreamReader("jackie.txt"))   //2. feladat Beolvasás
            { 
                file.ReadLine();
                while (!file.EndOfStream)
                {
                    adatok.Add(new Stat(file.ReadLine()));
                }

            }
            //3. feladat hűny adatsor van az állományban
            Console.WriteLine($"3. feladat: {adatok.Count}");

            //4. feladat melyik évben indult el a legtöbb versenyen
            Console.WriteLine($"4. feladat: {adatok.First(x => x.Versenyek == adatok.Max(y => y.Versenyek)).Ev}");

            //5. feladat Jackie Stewart számára melyik évtized mennyire volt sikeres
            Console.WriteLine($"5. feladat:\n\r\t70-as évek {adatok.Where(x => x.Ev >= 1970 && x.Ev < 1980).Sum(y => y.Gyozelmek)} megnyert verseny\n\r\t60-as évek {adatok.Where(x => x.Ev >= 1960 && x.Ev < 1970).Sum(y => y.Gyozelmek)}" + " megnyert verseny");

            
            using (StreamWriter html = new StreamWriter("jackie.html", false))
            {
                html.WriteLine("<!DOCTYPE html>");
                html.WriteLine("<html lang=\"HU\">");
                html.WriteLine("\t<head><style>thead, td{border: solid 2px #000; text-align: center;}body{background-color: lightblue;}</style></head>");
                html.WriteLine("\t<body>");
                html.WriteLine("\t\t<h1>Jackie Stewart</h1>");
                html.WriteLine("\t\t<table border=\"2px\">");
                html.WriteLine("\t\t\t<thead><tr><th>Év</th><th>Versenyek</th><th>Győzelmek</th></tr></thead>");            //6. feladat a html oldal elkészitése
                html.WriteLine("\t\t\t<tbody>");
                foreach (Stat item in adatok.OrderByDescending(x => x.Ev))
                {
                    html.WriteLine($"\t\t\t\t<tr><td>{item.Ev}</td><td>{item.Versenyek}</td><td>{item.Gyozelmek}</td></tr>");
                }
                html.WriteLine("\t\t\t</tbody>");
                html.WriteLine("\t\t</table>");
                html.WriteLine("\t</body>");
                html.WriteLine("</html>");
            }
            Console.WriteLine("6. feladat: jackie.html");
            Console.ReadKey();
        }
    }
}
