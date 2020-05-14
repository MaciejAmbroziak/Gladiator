using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gladiator
{
    public abstract class Gladiator : IView
    {
        string Name { get; }
        private int healthPoints { get; }
        private int strengthPoints { get; }
        private int dexterityPoints { get; }

        public double Health { get; protected set; }
        public double Strength {get; protected set; }
        public double Dexterity { get; protected set; }
        public int Level { get; set; }
        public enum Skill
        {
            Low,
            Medium,
            High
        }

        protected double FullGladiatorSkill(Skill value, double baseSkill) 
        {
            return baseSkill * SkillsMultiplier(value) * Level;
        }

        protected int GladiatorLevel()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }


        private double SkillsMultiplier(Skill value)
        {
            switch (value)
            {
                case Skill.Low:
                    return 0.75;
                case Skill.Medium:
                    return 1.0;
                case Skill.High:
                    return 1.25;
                default:
                    return 1;
            }
        }
        public Gladiator(string name, Skill healthModifierValue, Skill strengthModifierValue, Skill dexterityModifierValue)
        {
            Name = name;
            Health = FullGladiatorSkill(healthModifierValue, healthPoints);
            Strength = FullGladiatorSkill(strengthModifierValue, strengthPoints);
            Dexterity = FullGladiatorSkill(dexterityModifierValue, dexterityPoints);
            Level = GladiatorLevel();
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
