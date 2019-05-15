using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disjoint_Set
{
    class Node
    {
        public int Key { get; set; }
        public Node Parend { get; set; }

        public byte Rank { get; set; }

    }
}
