using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Archer : Gladiator
    {
        public Archer(string name) : base(name, Skill.Medium, Skill.Medium, Skill.High)
        {
        }
    }
}
