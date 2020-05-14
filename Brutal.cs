using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Brutal : Gladiator
    {
        public Brutal(string name) : base(name, Skill.High, Skill.High, Skill.Low)
        {
        }
    }
}
