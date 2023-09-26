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
        public DateTime Szerkesztve { get; private set; }

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
    }

}
