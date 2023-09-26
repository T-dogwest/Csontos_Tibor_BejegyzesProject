using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* List<Bejegyzes> bLista = new List<Bejegyzes>();

            bLista.Add(new Bejegyzes("sz1", "első tartalma."));
            bLista.Add(new Bejegyzes("sz2", "második tartalma."));

            foreach (Bejegyzes bejegyzes in bLista)
            {
                Console.WriteLine(bejegyzes.ToString());
            }*/

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

            Console.ReadKey();


        }

    }
}
