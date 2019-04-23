using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    class Node
    {
        //   private List<int> keys = new List<int> {get;set;}
        public  List<Node> childs { get; set; } = new List<Node>();
        public bool IsLeaf { get; set; }
        public List<int> keys { get; set; } = new List<int>();


}
}
