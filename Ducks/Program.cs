using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(17, KindOfDuck.Mallard),
                new Duck(18, KindOfDuck.Muscovy),
                new Duck(14, KindOfDuck.Decoy),
                new Duck(11, KindOfDuck.Muscovy),
                new Duck(14, KindOfDuck.Mallard),
                new Duck(13, KindOfDuck.Decoy)
            };

            Console.ReadKey();

            ducks.Sort();


            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
