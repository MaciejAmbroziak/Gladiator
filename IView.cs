using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    interface IView
    {
        public void Display();
        public int GetNumberBetween(int min, int max);

    }
}
