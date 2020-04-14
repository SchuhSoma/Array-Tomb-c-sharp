using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_1
{
    class Program
    {
        static Random rnd = new Random();
        static int[] tmb = new int[15];
        static string[] Nevek = new string[5];
        static int[] Tisztatmb = new int[15];
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------------------\n");
            TombFeltolt();
            Console.WriteLine("\n-----------------------------\n");
            TombKiiratas();
            Console.WriteLine("\n-----------------------------\n");
            Legkisebb();
            Console.WriteLine("\n-----------------------------\n");
            Legnagyobb();
            Console.WriteLine("\n-----------------------------\n");
            AmigNEm100();
            Console.WriteLine("\n-----------------------------\n");
            TombRendezes();
            Console.WriteLine("\n-----------------------------\n");
            Rendezes();
            Console.WriteLine("\n-----------------------------\n");
            MibolMennyi();
            Console.WriteLine("\n-----------------------------\n");
            TombSzavak();

            Console.ReadKey();
        }

        private static void TombSzavak()
        {
            Console.WriteLine("9.Feladat: Tömb nevekkel");
            Nevek = new string[5] { "Alma", "Petra", "Edina", "Nora", "Szilvi" };
            Array.Sort(Nevek);
            for (int i = 0; i <Nevek.Length; i++)
            {
                Console.WriteLine("{0}. név :=> {1}", i + 1,Nevek[i]) ;
            }
        }

        private static void MibolMennyi()
        {
            Console.WriteLine("8.Feladat: Miből mennyi van");
            for (int i = 0; i < tmb.Length; i++)
            {
                
                int db = 0;
                for (int j = 0; j < tmb.Length; j++)
                {
                    if(tmb[i]==tmb[j])
                    {
                        db++;
                    }
                }
                Console.WriteLine("{0} :=> {1}", tmb[i], db);
                
            }
        }

        private static void Rendezes()
        {
            Console.WriteLine("7.Feladat:Tömb rendezés: Buborékrendezése");
            int Hossz = tmb.Length;
            int a;
            for (int i = Hossz-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if(tmb[j]>tmb[j+1])
                    {
                        a = tmb[j];
                        tmb[j] = tmb[j + 1];
                        tmb[j + 1] = a;
                    }
                }                
            }
            for (int i = 0; i < Hossz; i++)
            {
                Console.WriteLine("\t{0:00}. elem => {1}", i + 1, tmb[i]);
            }
        }

        private static void TombRendezes()
        {
            Console.WriteLine("6.Feladat: Tömb rendezése");
            Array.Sort(tmb);
            for (int i = 0; i < tmb.Length; i++)
            {
                Console.WriteLine("\t{0:00}. elem => {1}", i + 1, tmb[i]);
            }
        }

        private static void AmigNEm100()
        {
            Console.WriteLine("5.Feladat: Összeadni az elemet amig az összeg nem 100");
            int Osszeg = 0;
            int db = 0;
            int i = -1;
            do
            {
                i++;
                Console.WriteLine("\t{0:00}. elem => {1}", i + 1, tmb[i]);
                Osszeg+= tmb[i];
                db++;
                
            } while (Osszeg <= 100);
            Console.WriteLine("\tEnnyi elemet kell összeadni : {0}", db);

        }

        private static void Legnagyobb()
        {
            Console.WriteLine("4.Feladat: legnagyobb érték");
            int Legnagyobb = 0;
            int Hanyadik = 0;
            for (int i = 0; i < tmb.Length; i++)
            {
                if (tmb[i] > Legnagyobb)
                {
                    Legnagyobb = tmb[i];
                    Hanyadik = i + 1;
                }
            }
            Console.WriteLine("\tA legkisebb elem értéke: {0}", Legnagyobb);
            Console.WriteLine("\tA legkisebb elem sorrszáma :{0}", Hanyadik);
        }

        private static void Legkisebb()
        {
            Console.WriteLine("3.Feladat: legkisebb érték");
            int Legkisebb = 101;
            int Hanyadik = 0;
            for (int i = 0; i < tmb.Length; i++)
            {
                if(tmb[i]<Legkisebb)
                {
                    Legkisebb = tmb[i];
                    Hanyadik = i+1;
                }
            }
            Console.WriteLine("\tA legkisebb elem értéke: {0}", Legkisebb);
            Console.WriteLine("\tA legkisebb elem sorrszáma :{0}", Hanyadik);
        }

        private static void TombKiiratas()
        {
            Console.WriteLine("2.Feladat: Tömb elemeinek kiiratása");
            for (int i = 0; i < tmb.Length; i++)
            {
                Console.WriteLine("\t{0:00}. elem => {1}", i+1,tmb[i]);
            }
        }

        private static void TombFeltolt()
        {
            Console.WriteLine("1.Feladat: Tömb elemekkel való feltöltése");
            for (int i = 0; i <tmb.Length; i++)
            {
                tmb[i] = rnd.Next(1,20);
            }
        }
    }
}
