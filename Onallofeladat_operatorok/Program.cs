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
            Harmadikfeladat(kifejezes);
            Negyedikfeladat(kifejezes);

            Console.ReadKey();
        }

        private static void Negyedikfeladat(List<Kif> kifejezes)
        {
            bool van = false;
            int index = 0;
            while (!van && index <kifejezes.Count)
	        {
                if (kifejezes[index].elso % 10 == 0 && kifejezes[index].masodik % 10 ==0)
	            {
                    van = true;
                    Console.WriteLine($"Negyedik feladat: Van ilyen kifejezés");
	            }
                index++;
	        }
            if (!van)
	        {
                Console.WriteLine("Negyedik feladat: Nincs ilyen kifejezés.");
	        }
        }

        private static void Harmadikfeladat(List<Kif> kifejezes)
        {
            int darab = 0;
            foreach (var item in kifejezes)
	        {
                if (item.jelek == "mod")
	            {
                    darab ++;
	            }
	        }
            Console.WriteLine($"Harmadik feladat: {darab}");
        }


      

       

        private static void Masodikfeladat(List<Kif> kifejezes)
        {
            Console.WriteLine($"Második feladat: Kifejezések száma: {kifejezes.Count}");
        }


    }
}
