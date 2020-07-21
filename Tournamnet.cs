using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Gladiator
{
    public class Tournament
    {
        public BinnaryTree TournamentTree { get; set; }
        public int Turn { get; private set; } = 0;
        public Tournament(int numberOfGladiators)
        {
            this.TournamentTree = new BinnaryTree();
            GladiatorFactory trainingField = new GladiatorFactory();
            for (int i = 0; i <= numberOfGladiators; i++)
            {
                Gladiator gladiator = trainingField.GenerateRandomGladiator();
                this.TournamentTree.Insert(gladiator);
            }

        }
       /*public void Simulate()
        {
            Gladiator gladiator1;
            Gladiator gladiator2;
            Turn++;
            if (Turn % 2 == 0)
            {
                gladiator1 = this.TournamentTree.PickToFigth().Left.Gladiator; 
                gladiator2 = this.TournamentTree.PickToFigth().Rigth.Gladiator;
            }
            else
            {
                gladiator1 = this.TournamentTree.PickToFigth().Rigth.Gladiator; 
                gladiator2 = this.TournamentTree.PickToFigth().Left.Gladiator;
            }

            double dexterityDifference = DexterityNormalization(gladiator1, gladiator2);
            Random rnd = new Random();
            double diceThrow = rnd.Next(0, 100);
            if (diceThrow > dexterityDifference)
            {
                Console.WriteLine("Missed");
            }
            else
            {
                DamageTaken(gladiator1, gladiator2);
                if (gladiator1.Health < 0)
                {
                    Console.WriteLine("FirstGladiator Dies");
                }
                else
                {
                    Console.WriteLine("FirstGladiator Takes ... Damage");
                }
            }
        }*/
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
            return gladiator.Stength * coeficient;
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