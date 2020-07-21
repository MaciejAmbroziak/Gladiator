using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many Gladiators?");
            int gladiatorsNumber = int.Parse(Console.ReadLine());
            Tournament tournament = new Tournament(gladiatorsNumber);

        }
    }
}
