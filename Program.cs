using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            GladiatorFactory trainingField = new GladiatorFactory();     
            BinnaryTree combatSchedule = new BinnaryTree();
            Console.WriteLine("How many gladiators? (2, 4, 8, 16, 32)");
            int numberOfGladiators = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGladiators; i++)
            {
                Gladiator Gladiator = trainingField.GenerateRandomGladiator();
                combatSchedule.Insert(Gladiator);
            }
            
        }
    }
}
