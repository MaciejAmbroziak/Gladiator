using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Assassin : Gladiator
    {
        public Assassin(string name) : base(name, Skill.Low, Skill.High, Skill.High)
        {
        }
    }
    
}
