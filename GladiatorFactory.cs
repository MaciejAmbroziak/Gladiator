using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class GladiatorFactory
    {
        public Gladiator GenerateRandomGladiator()
        {
            Gladiator fighter;
            Random rnd = new Random();
            int type = rnd.Next(0, 5);
            switch (type)
            {
                case 1:
                    fighter = new Swordsman("Zbigniew");
                    break;
                case 2:
                    fighter = new Assassin("Wojciech");
                    break;
                case 3:
                    fighter = new Brutal("Jaroslaw");
                    break;
                case 4:
                    fighter = new Swordsman("Slawomir");
                    break;
                default:
                    fighter = new Swordsman("Kermit");
                    break;
            }
            return fighter;
        }
    }
}