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
            List<Bejegyzes> bLista = new List<Bejegyzes>();

            bLista.Add(new Bejegyzes("sz1", "első tartalma."));
            bLista.Add(new Bejegyzes("sz2", "második tartalma."));

            foreach (Bejegyzes bejegyzes in bLista)
            {
                Console.WriteLine(bejegyzes.ToString());
            }
            Console.ReadKey();
        }
    }
}
