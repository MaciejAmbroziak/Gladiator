using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{

    public class Node
    {
        public Node Rigth { get; set; }
        public Node Left { get; set; }
        public Gladiator Gladiator { get; set; }
    }

    public class BinnaryTree
    { 
        public Node root { get; set; }
        public void Insert(Gladiator gladiator)
        {
            bool goLeft = true;
            if (goLeft)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Gladiator = gladiator;
                    return;
                }
                if (root != null)
                {
                    if (root.Left == null && root.Rigth == null)
                    {
                        root.Left = new Node();
                        root.Left.Gladiator = root.Gladiator;
                        root.Rigth = new Node();
                        root.Rigth.Gladiator = gladiator;
                        return;
                    }
                    if (root.Left == null)
                    {
                        root.Left = new Node();
                        root.Left.Gladiator = gladiator;
                    }
                    else
                    {
                        root.Rigth = new Node();
                        root.Rigth.Gladiator = gladiator;
                    }
                }
            }
           
        }
        public Node GetGladiatorsPairRoot()
        {

            return root;
        }
    }

   
}
