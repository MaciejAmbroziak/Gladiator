using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Node
    {
        public Gladiator Gladiator { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node()
        {

        }
        public Node(Gladiator gladiator)
        {
            this.Gladiator = gladiator;
        }

        internal void Insert(Gladiator gladiator)
        {
            bool goRight = false;
            if (Gladiator == null)
            {
                if (Right == null && Left == null)
                {
                    Gladiator = gladiator;
                }
                else
                {
                    if (goRight)
                    {
                        if (Right == null)
                        {
                            Right.Insert(gladiator);
                        }
                        else
                        {
                            Left.Insert(gladiator);
                        }
                    }
                    goRight = !goRight;
                }
            }
            else
            {
                Left = new Node();
                Right = new Node();
                Left.Insert(gladiator);
                Right.Insert(gladiator);
                Gladiator = null;
            }
        }
    }
}