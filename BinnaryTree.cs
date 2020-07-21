using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Net.Http.Headers;
using System.Text;

namespace Gladiator
{
    public class BinnaryTree
    {
        public Node Root { get; set; }

        public BinnaryTree()
        {

        }
        public BinnaryTree(Node node)
        {
            Root = node;
        }

        public void Insert(Gladiator gladiator)
        {
            if (Root != null)
            {
                Root.Insert(gladiator);
            }
            else
            {
                Root = new Node(gladiator);
            }
        }
    }
}