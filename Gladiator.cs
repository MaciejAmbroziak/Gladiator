using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gladiator
{
    public enum Skill
    {
        Low,
        Medium,
        High
    }
    public abstract class Gladiator : IView
    {
        string Name { get; }
        private int healthPoints { get; }
        private int strengthPoints { get; }
        private int dexterityPoints { get; }
        public double Health { get; set; }
        public double Stength { get; set; }
        public double Dexterity {get; set;}


        public Gladiator(string name, Skill health, Skill strength, Skill dexterity)
        {
            this.Name = name;
            Random rnd = new Random();
            this.healthPoints = rnd.Next(0, 100);
            this.strengthPoints = rnd.Next(0, 100);
            this.dexterityPoints = rnd.Next(0, 100);
            this.Health = this.healthPoints * SkillValue(health);
            this.Stength = this.strengthPoints * SkillValue(strength);
            this.Dexterity = this.dexterityPoints * SkillValue(dexterity);
        }
        public double SkillValue(Skill level)
        {
            switch (level)
            {
                case (Skill.Low):
                    return 0.7;
                case (Skill.Medium):
                    return 1.0;
                case (Skill.High):
                    return 1;
                default:
                    return 1.3;

            }
               
        }
        protected int GladiatorLevel()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public static int GetNumberBetweenValues(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }

        public int GetNumberBetween(int min, int max)
        {
            throw new NotImplementedException();
        }
    }
}
