using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorApp
{
    class Warrior
    {
        // define the getters and setters along with default values in case you do not provide one
        public string Name { get; set; } = "Warrior";
        public double Hp { get; set; } = 1000;
        public double Atk { get; set; } = 120;
        public double Block { get; set; } = 40;

        // create a single rand instance to avoid value repeating over n over. Since this syncs based on system clock
        private static Random random = new Random();

        public Warrior(string name, double health = 0, double atkMax = 0, double blkMax = 0)
        {
            Name = name;
            Hp = health;
            Atk = atkMax;
            Block = blkMax;
        }

        public double RndAtk()
        {
            return random.Next(1, (int)Atk);
        }

        public double RndBlock()
        {
            return random.Next(1, (int)Block);
        }

    }
}
