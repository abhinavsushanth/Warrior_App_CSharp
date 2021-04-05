using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorApp
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            double fighter1_hp = warrior1.Hp;
            double fighter2_hp = warrior2.Hp;

            double rndAtk1, rndAtk2, rndBlk1, rndBlk2;


            while (fighter1_hp > 0 && fighter2_hp > 0)
            {
                rndAtk1 = warrior1.RndAtk();
                rndAtk2 = warrior2.RndAtk();
                rndBlk1 = warrior1.RndBlock();
                rndBlk2 = warrior2.RndBlock();

                fighter1_hp = fighter1_hp + rndBlk1 - rndAtk2;
                fighter2_hp = fighter2_hp + rndBlk2 - rndAtk1;

                Console.WriteLine($"{warrior1.Name} attacks {warrior2.Name} and deals {rndAtk1} damage");
                Console.WriteLine($"{warrior2.Name} has {fighter2_hp} health");
                Console.WriteLine("");
                Console.WriteLine($"{warrior2.Name} attacks {warrior1.Name} and deals {rndAtk2} damage");
                Console.WriteLine($"{warrior1.Name} has {fighter1_hp} health");
                Console.WriteLine("");
            }

            if (fighter1_hp <=0 && fighter2_hp <= 0)
            {
                Console.WriteLine("Both warriors have died");
            }
            else if (fighter1_hp <= 0)
            {
                Console.WriteLine($"{warrior1.Name} has died. {warrior2.Name} is victorious");
            }
            else if (fighter2_hp <= 0)
            {
                Console.WriteLine($"{warrior2.Name} has died. {warrior1.Name} is victorious");
            }
            Console.WriteLine("Game Over");
        }
    }

}
