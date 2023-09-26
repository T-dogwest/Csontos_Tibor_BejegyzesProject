using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    internal class Bejegyzes
    {
        public string Szerzo { get; }
        public string Tartalom { get; set; }
        public int Likeok { get; private set; }
        public DateTime Letrejott { get; }
        public DateTime Szerkesztve { get; set; }

        public Bejegyzes(string szerzo, string tartalom)
        {
            Szerzo = szerzo;
            Tartalom = tartalom;
            Likeok = 0;
            Letrejott = Szerkesztve = DateTime.Now;
        }

        public void Like()
        {
            Likeok++;
        }

        public override string ToString()
        {
            string szerkesztes = Szerkesztve != Letrejott ? $"Szerkeszve: {Szerkesztve}" : "";
            return $"{Szerzo}–{Likeok}–{Letrejott}{szerkesztes}: {Tartalom}";
        }

    }

}
