using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace operatorok3
{
    class Kif
    {
        public int elso;
        public string jelek;
        public int masodik;

        public Kif(string sor)
        {
            List<string> atmeneti = sor.Split().ToList();
            elso = Convert.ToInt32(atmeneti[0]);
            jelek = atmeneti[1];
            masodik = Convert.ToInt32(atmeneti[2]);

        }
    }





    class Program
    {

        static void Main(string[] args)
        {
            List<Kif> kifejezes = new List<Kif>();
            foreach (var i in File.ReadAllLines("kifejezesek.txt"))
            {
                kifejezes.Add(new Kif(i));
            }


            Masodikfeladat(kifejezes);
            Harmadikfeladat();

            Console.ReadKey();
        }

        private static void Harmadikfeladat()
        {
            Console.WriteLine("Harmadik feladat: Hány ");

        }

        private static void Masodikfeladat(List<Kif> kifejezes)
        {



            Console.WriteLine($"Kifejezések száma: {kifejezes.Count}");
        }


    }
}
