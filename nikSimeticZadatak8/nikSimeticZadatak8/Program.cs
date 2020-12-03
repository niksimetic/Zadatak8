using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport Cruling = new Sport("Curling");
            Sport Vaterpolo = new Sport("Vaterpolo", true);
            Sport Nogomet = new Sport("Nogomet", true, 11);
        }
    }
}
