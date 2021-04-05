using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior spartacus = new Warrior("Spartacus", 1000, 120, 40);
            Warrior gannicus = new Warrior("Gannicus", 1000, 120, 40);

            Battle.StartFight(spartacus, gannicus);

            Console.ReadLine();
        }
    }
}
