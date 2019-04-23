using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    class Btree
    {
        private readonly int rank;
        private Node root;

        public Btree(int rank)
        {
            this.rank = rank;
            root = new Node();
        }


        void BTreeInsertNonFull(ref Node root,int key)
        {
            int i = root.keys.Count();
            if(root.IsLeaf)
            {
               /* while(i>=1 && key < root.keys[i])
                {
                    root.keys[i + 1] = root.keys[i];
                    i = i - 1;
                }*/


                root.keys.Add(key);
                root.keys.Sort();
                //DISC WRITE

            }
            else
            {

                root.keys.Add(key);
                root.keys.Sort();
                //DISC READ
                if()

            }
        }


    }
}
