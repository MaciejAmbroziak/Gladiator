using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Gladiator
{
    class Combat
    {
        Gladiator FirstGladiator;
        Gladiator SecondGladiator;
        public Combat(BinnaryTree Tournament)
        {
            Tournament.root
            FirstGladiator = Arena.GenerateRandomGladiator();
            SecondGladiator = Arena.GenerateRandomGladiator();
        }
        public void Simulate()
        {
            double dexterityDifference = DexterityNormalization(FirstGladiator, SecondGladiator);
            Random rnd = new Random();
            double diceThrow = rnd.Next(0, 100);
            if (diceThrow > dexterityDifference)
            {
                Console.WriteLine("Missed");
            }
            else
            {
                DamageTaken(FirstGladiator,SecondGladiator);
                if(FirstGladiator.Health < 0)
                {
                    Console.WriteLine("FirstGladiator Dies");
                }
                else
                {
                    Console.WriteLine("FirstGladiator Takes ... Damage");
                }
            }
        }
        private double DexterityNormalization(Gladiator attacker, Gladiator deffender)
        {
            double dexterityDifference = attacker.Dexterity - deffender.Dexterity;
            if (dexterityDifference < 10)
            {
                dexterityDifference = 10;
            }
            else if (dexterityDifference > 100)
            {
                dexterityDifference = 100;
            }
            return dexterityDifference;
        }
        private double DamageDone(Gladiator gladiator)
        {
            Random rnd = new Random();
            double coeficient = rnd.NextDouble();
            coeficient /= 2;
            if (coeficient < 0.1)
            {
                coeficient = 0.1;
            }
            return gladiator.Strength * coeficient;
        }
        private void DamageTaken(Gladiator deffender, Gladiator attacker)
        {
           deffender.Health -= DamageDone(attacker);
        }
        private bool Survived(Gladiator gladiator)
        {
            return gladiator.Health > 0;
        }
    }
}