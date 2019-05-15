using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Disjoint_Set
{
    class Alghoritm
    {

        public Node MakeSet(int key)
        {
            Node set = new Node();
            set.Key = key;
            set.Parend = set;
            set.Rank = 0;

            return set;


        }

        public Node FindSet(Node node)
        {
            if (node != node.Parend)
            {
                node.Parend = FindSet(node.Parend);
            }

            return node.Parend;
        }

        public void Union(Node x,Node y)
        {
            if (x.Rank > y.Rank)
                y.Parend = x;
            else
                x.Parend = y;
            if (x.Rank == y.Rank)
                    y.Rank++;
        }

        public void DrawPath(Node node)
        {
            
            while (node.Parend != node)
            {

                Console.Write(node.Key + " ");
               
                node = node.Parend;
            }

            Console.Write(node.Key);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        void UnionWrapper(Node x, Node y)
        {


            Union(FindSet(x), FindSet(y));

        }

        class Graph 
        {
            public short u, v, w;

            public Graph(short u,short v,short w)
            {
                this.u = u;
                this.v = v;
                this.w = w;
            }
        }
        void Kruskal(int[] V, Graph[] E)
        {
           Node[] nodes =  new Node[10];
           Node ru, rv;
           for (int i = 0; i < V.Length; i++)
           {
               nodes[i] = MakeSet(V[i]);

           }

           E = E.OrderBy(g => g.w).ToArray();

            for (int i = 0; i < E.Length; i++)
           {
                ru = FindSet(nodes[E[i].u]);
                rv = FindSet(nodes[E[i].v]);
               if (ru != rv)
               {
                   Console.WriteLine(nodes[E[i].v].Key + "--" + E[i].w + "--" + nodes[E[i].u].Key);
                   Union(ru,rv);
               }
           }
       }
    


        public void Test()
        {
            Node n1 = MakeSet(1);
            Node n2 = MakeSet(2);
            Node n3 = MakeSet(3);
            Node n4 = MakeSet(4);
            Node n5 = MakeSet(5);
            Node n6 = MakeSet(6);
            Node n7 = MakeSet(7);
            Node n8 = MakeSet(8);
            Node n9 = MakeSet(9);

            UnionWrapper(n2,n1);
            DrawPath(n2);

            UnionWrapper( n4, n3);

            DrawPath(n4);

            UnionWrapper(n4, n5);

            DrawPath(n5);


            UnionWrapper(n5,n1);

            DrawPath(n5);

            UnionWrapper(n7,n6);
            DrawPath(n7);

            UnionWrapper(n9, n8);
            DrawPath(n9);

            UnionWrapper(n8, n6);
            DrawPath(n9);

            UnionWrapper(n4, n7);
            DrawPath(n4);
            DrawPath(n5);


            Console.WriteLine("KRUSKAL");




            Graph[] E =
            {
                new Graph(0,1,7),
                new Graph(1,2,6),
                new Graph(2,3,5),
                new Graph(3,4,2),
                new Graph(4,5,3),
                new Graph(5,0,8),

                new Graph(5,1,3),
                new Graph(4,2,2),
                new Graph(5,2,4),


            };
            int[] V = { 0, 1, 2, 3,4,5 };
            Kruskal(V,E);
            Console.ReadKey();

        }


    }
}
