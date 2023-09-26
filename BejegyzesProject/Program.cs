using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
   
    internal class Program
    {
        static void feladat01()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();

            bLista.Add(new Bejegyzes("sz1", "első tartalma."));
            bLista.Add(new Bejegyzes("sz2", "második tartalma."));

            foreach (Bejegyzes bejegyzes in bLista)
            {
                Console.WriteLine(bejegyzes.ToString());
            }
        }
        static void feladat02()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();

            Console.Write("Bejegyzések Száma: ");
            if (int.TryParse(Console.ReadLine(), out int darabszam) && darabszam > 0)
            {
                for (int i = 0; i < darabszam; i++)
                {
                    Console.Write($"Add meg a {i + 1}.  szerzőjét: ");
                    string szerzo = Console.ReadLine();

                    Console.Write($"Add meg a {i + 1}. tartalmát: ");
                    string tartalom = Console.ReadLine();

                    bLista.Add(new Bejegyzes(szerzo, tartalom));
                }

                Console.WriteLine("\nelkeszult:");
                foreach (Bejegyzes bejegyzes in bLista)
                {
                    Console.WriteLine(bejegyzes.ToString());
                }
            }
            else
            {
                Console.WriteLine("pozití,egész számot írj");
            }
        }
        static void feladat03()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();


            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }

            Console.WriteLine("\nbejegyzések:");
            foreach (Bejegyzes bejegyzes in bLista)
            {
                Console.WriteLine(bejegyzes.ToString());
            }
            Console.ReadKey();
        }
        static void feladat04()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();

           
            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }

            
            Random random = new Random();
            int oLikeok = bLista.Count * 20;

            for (int i = 0; i < oLikeok; i++)
            {
                int index = random.Next(bLista.Count); 
                bLista[index].Like(); 
            }

            Console.WriteLine("\nbejegyzések:");
            foreach (Bejegyzes bejegyzes in bLista)
            {
                Console.WriteLine(bejegyzes.ToString());
            }
        }
        static void feladat05()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();

            
            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';'); 
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }

            Console.WriteLine("\n bejegyzések:");
            for (int i = 0; i < bLista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. bejegyzés:\n{bLista[i]}");
            }

        
            Console.Write("\nAdj meg egy új tartalmat: ");
            string ut = Console.ReadLine();

            
            if (bLista.Count >= 2)
            {
                bLista[1].Tartalom = ut;
                bLista[1].Szerkesztve = DateTime.Now;
                Console.WriteLine("\n sikeresen módosítva.");
            }
       

           
            Console.WriteLine("\n valtoztatott:");
            for (int i = 0; i < bLista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. bejegyzés:\n{bLista[i]}");
            }
        }
        static void feladat06()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();

           
            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }

          
            Bejegyzes nepszer = null;
            int mlike = -1;

            foreach (var bejegyzes in bLista)
            {
                if (bejegyzes.Likeok > mlike)
                {
                    mlike = bejegyzes.Likeok;
                    nepszer = bejegyzes;
                }
            }

            if (nepszer != null)
            {
                Console.WriteLine($"legnépszerűbb bejegyzés : {nepszer.Likeok}");
            }
            else
            {
                Console.WriteLine("Nincs bejegyzés.");
            }
        }
        static void feladat07() {
            List<Bejegyzes> bLista = new List<Bejegyzes>();


            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }
            bool vane= bLista.Any(b => b.Likeok > 35);

            if (vane)
            {
                Console.WriteLine("Van.");
            }
            else
            {
                Console.WriteLine("Nincs.");
            }
        }
        static void feladat08()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();


            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }
            int keves = bLista.Count(b => b.Likeok <= 15);

            Console.WriteLine($"15 like alatti bejegyzések száma: {keves}");
        }
        static void feladat09()
        {
            List<Bejegyzes> bLista = new List<Bejegyzes>();


            using (StreamReader sr = new StreamReader("bejegyzesek.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 2)
                    {
                        string szerzo = adatok[0];
                        string tartalom = adatok[1];
                        bLista.Add(new Bejegyzes(szerzo, tartalom));
                    }
                }
            }
            List<Bejegyzes> rLista = bLista.OrderByDescending(b => b.Likeok).ToList();

          
            using (StreamWriter sw = new StreamWriter("bejegyzesek_rendezett.txt"))
            {
                foreach (var bejegyzes in rLista)
                {
                    sw.Write(bejegyzes.ToString());
                }
            }

            Console.WriteLine(" bejegyzések  a 'bejegyzesek_rendezett.txt' fájlba.");
        }
    
            static void Main(string[] args)
        {
           
            feladat03();
            
          Console.ReadKey();
        }

    }
}
