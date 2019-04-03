using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrzewoCzCz
{
    public enum Colour : int
    {
        BLACK = 0,
        RED = 1
    }
    public class RedBlackTree
    {
        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node Parent { get; set; }

            public int NodeColour { get; set; }

            public int Key { get; set; }
            public string Name { get;  set; }

            public Node(int key,string name)
            {
                this.Key = key;
                this.Name = name;
            }

            public Node()
            {

            }

        }

        Node newNode(int key,string name)
        {
            Node n1 = new Node(key,name)
            {
                Right = nil,
                Left = nil,
                Parent = nil
                
            };
            return n1;
        }

        public RedBlackTree()
        {
            Start();
        }

        private void Start()
        {



            //WSTAIWNIE
            //PRZYPADEK 1 brat ojca x czerwony
            /*
            root = nil;
            Node p11 = this.newNode(5, "p11");
            Node p12 = this.newNode(4, "p12");
            Node p13 = this.newNode(6, "p13");
            Node p14 = this.newNode(3, "p14");

            this.RB_insert(ref p11);
            this.RB_insert(ref p12);
            this.RB_insert(ref p13);

            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p14);


            draw_tree_hor(root);
            Console.ReadKey();

            */
            //WSTAIWNIE


            //PRZYPADEK 1-3  brat ojca węzła x jest czarny, węzeł x i jego
           // ojciec leżą w różnych kierunkach tworząc zakręt
            /*
            root = nil;
            Node p11 = this.newNode(8, "p11");
            Node p12 = this.newNode(5, "p12");
            Node p13 = this.newNode(15, "p13");
            Node p14 = this.newNode(12, "p14");
            Node p15 = this.newNode(19, "p15");
            Node p16 = this.newNode(9, "p16");
            Node p17 = this.newNode(13, "p17");
            Node p18 = this.newNode(23, "p18");
            Node p19 = this.newNode(10, "p19");




            this.RB_insert(ref p11);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p12);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p13);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p14);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p15);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p16);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p17);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p18);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            //wstawianie ze zmiana
            this.RB_insert(ref p19);
            draw_tree_hor(root);
            Console.ReadKey();


            */
            //PRZYPADEK 3
            /*
            root = nil;
            Node p11 = this.newNode(20, "p11");
            Node p12 = this.newNode(15, "p12");
            Node p13 = this.newNode(27, "p13");
            Node p14 = this.newNode(11, "p14");
            Node p15 = this.newNode(18, "p15");
            Node p16 = this.newNode(10, "p16");


            this.RB_insert(ref p11);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p12);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p13);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p14);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p15);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p16);
            draw_tree_hor(root);
            Console.ReadKey();
           */
            //USUWANIE

            //PRZYPADEK 1 = brat jest czerwony  


            
            root = nil;
            Node p1 = this.newNode(38, "p1");
            Node p2 = this.newNode(31, "p2");
            Node p3 = this.newNode(22, "p3");
            Node p4 = this.newNode(8, "p4");
            Node p5 = this.newNode(20, "p5");
            Node p6 = this.newNode(5, "p6");
            Node p7 = this.newNode(10, "p7");
            Node p8 = this.newNode(9, "p8");
            Node p9 = this.newNode(21, "p9");
            Node p10 = this.newNode(27, "p10");
            Node p11 = this.newNode(29, "p11");
            Node p12 = this.newNode(25, "p12");

           

            this.RB_insert(ref p1);
   
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p2);
          
            this.RB_insert(ref p3);
         
            this.RB_insert(ref p4);
     
            this.RB_insert(ref p5);
          
           this.RB_insert(ref p6);
  
            this.RB_insert(ref p7);
   
            this.RB_insert(ref p8);
         
            this.RB_insert(ref p9);
           
            this.RB_insert(ref p10);
       
            this.RB_insert(ref p11);
      
            this.RB_insert(ref p12);
            draw_tree_hor(root);


            Console.ReadKey();

           this.RB_Delete(root, "p1");
            Console.Clear();
            draw_tree_hor(root);
            Console.ReadKey();

            





            //USUWANIE

            //PRZYPADEK 2 = brat węzłą x i obydwaj synowie brata czarni
            
            /*
            root = nil;
            Node p1 = this.newNode(38, "p1");
            Node p2 = this.newNode(12, "p2");
            Node p3 = this.newNode(55, "p3");
            Node p4 = this.newNode(6, "p4");
            Node p5 = this.newNode(15, "p5");

            this.RB_insert(ref p1);
            this.RB_insert(ref p2);
            this.RB_insert(ref p3);
            this.RB_insert(ref p4);
            this.RB_insert(ref p5);


   
            Console.Clear();
            draw_tree_hor(root);
            Console.ReadKey();


            Console.Clear();
            this.RB_Delete(root, "p2");

            draw_tree_hor(root);
            Console.ReadKey();
            
            */




            //Przypadek 3 //brat x czarny,syn brata skierowany tak jal x jest czerwnony a drugi syn czarny,do przypadku 4
            /*
            root = nil;
            Node p1 = this.newNode(38, "p1");
            Node p2 = this.newNode(31, "p2");
            Node p3 = this.newNode(22, "p3");
            Node p4 = this.newNode(8, "p4");
            Node p5 = this.newNode(20, "p5");
            Node p6 = this.newNode(5, "p6");
            Node p7 = this.newNode(10, "p7");
            Node p8 = this.newNode(9, "p8");
            Node p9 = this.newNode(21, "p9");
            Node p10 = this.newNode(27, "p10");
            Node p11 = this.newNode(29, "p11");
            Node p12 = this.newNode(25, "p12"); 

            this.RB_insert(ref p1);
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            this.RB_insert(ref p2);

            this.RB_insert(ref p3);

            this.RB_insert(ref p4);

            this.RB_insert(ref p5);

            this.RB_insert(ref p6);

            this.RB_insert(ref p7);

            this.RB_insert(ref p8);

            this.RB_insert(ref p9);

            this.RB_insert(ref p10);

            this.RB_insert(ref p11);

            this.RB_insert(ref p12);
            draw_tree_hor(root);

            this.RB_Delete(root, "p3");
            Console.Clear();
            draw_tree_hor(root);
            Console.ReadKey();
            Console.Clear();
            */
            //Przypadek 4 brat x czarny, syn brata skierowany przeciwnie niż x jest czerwony. 





            int numer =0;
            Console.WriteLine("Ilosc czerwonych wezlow:"+Count_Red_Nodes(ref root,ref numer));
            Console.WriteLine("Minimalna glebokosc:"+minimumDepth(root));
            Console.WriteLine("Maksymalna glebokosc:"+maxDepth(root));
            Console.ReadKey();
        }

        private readonly Node nil = new Node
        {
            NodeColour = (int)Colour.BLACK,
            Left = null,
            Right = null,
            Parent = null,
            Name = "NIL"
            
        };

        private Node root;
        //WYSZUKIWANIE PO KLUCZU
        Node Tree_Search(Node x,int key)
        {
            if (x == nil || key == x.Key)
                return x;
            if (key < x.Key)
                return Tree_Search(x.Left,key);
            else
                return Tree_Search(x.Right,key);

        }
        Node Inorder_FindNode(Node root,string Name)
        {
            Boolean leftdone = false;

            // Start traversal from root 
            while (root != nil)
            {

                if (!leftdone)
                {
                    while (root.Left != nil)
                    {
                        root = root.Left;
                    }
                }

                // sprawdz czy imie jest rowne podanemu imieniu
                if (root.Name.Equals(Name))
                    break;

                // lewy strona jest skonczona
                leftdone = true;

                // jesli prawe dziecko istnieje
                if (root.Right != nil)
                {
                    leftdone = false;
                    root = root.Right;
                }

                // jesli prawe dziecko nie istnieje,  
                // idz do rodzica
                else if (root.Parent != nil)
                {
                    //jesli ten node jest prawym dzieckiem
                    // wracamy do rodzica
                    while (root.Parent != nil &&
                           root == root.Parent.Right)
                        root = root.Parent;

                    if (root.Parent == nil)
                        break;
                    root = root.Parent;
                }
                else
                    break;
            }

            return root;
        }

        //WYSZUKIWANIE PO NAZWIE
        private void LeftRotate(ref Node x)
        {

            Node y = x.Right;
            x.Right = y.Left;
            if (y.Left != nil)
                y.Left.Parent = x;
            y.Parent = x.Parent;
            if (x.Parent == nil)
                root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else
                x.Parent.Right = y;
            y.Left = x;
            x.Parent = y;


        }
        private void RightRotate(ref Node x)
        {

            Node y = x.Left;
            x.Left = y.Right;
            if (y.Right != nil)
                y.Right.Parent = x;
            y.Parent = x.Parent;
            if (x.Parent == nil)
                root = y;
            else if (x == x.Parent.Right)
                x.Parent.Right = y;
            else
                x.Parent.Left = y;
            y.Right = x;
            x.Parent = y;


        }


        void RB_insert(ref Node z)
        {
            Node y = nil;
            Node x = root;
            while (x != nil)
            {
                y = x;
                if (z.Key < x.Key)
                    x = x.Left;
                else
                    x = x.Right;
            }

            z.Parent = y;
            if (y == nil)
                root = z;
            else if (z.Key < y.Key)
                y.Left = z;
            else
                y.Right = z;
            z.Left = nil;
            z.Right = nil;
            z.NodeColour = (int)Colour.RED;
            RB_Insert_Fixup(ref z);

        }

        void RB_Insert_Fixup(ref Node z)
        {
   
            while (z.Parent.NodeColour == (int)Colour.RED && z!= root)
            {
                if (z.Parent == z.Parent.Parent.Left)                    //SPRAWDZAMY CZY LEWY 
                {
                  

                    Node y = z.Parent.Parent.Right;
                    if (y.NodeColour == (int)Colour.RED)                 //SPRAWDZAMY CZY BRAT OJCA JEST CZERWONY
                    {
                        z.Parent.NodeColour = (int)Colour.BLACK;         //ZMIENIAMY OJCU Y  KOLOR NA CZARNY
                        y.NodeColour = (int)Colour.BLACK;                //ZMIeniamy bratu ojca Y kolor na czarny  
                        z.Parent.Parent.NodeColour = (int)Colour.RED;    //ZMIANA OJCU OJCA  Y KOLOR NA CZRWONY
                        z = z.Parent.Parent;                             //NOWYM Y JEST OJCIEC OJCA Y 

                    }
                    else
                    {
                        if (z == z.Parent.Right) //PRZYPADEK 2 
                        {
                            z = z.Parent; //
                            LeftRotate(ref z);
                        }
                                                                          //Przypadek 3
                            z.Parent.NodeColour = (int) Colour.BLACK;
                            z.Parent.Parent.NodeColour = (int) Colour.RED;
                            Node zp = z.Parent.Parent;
                            RightRotate(ref zp);
                        
                    }

                }
                else
                {
                    Node y = z.Parent.Parent.Left;
                    if (y.NodeColour == (int)Colour.RED)
                    {
                        z.Parent.NodeColour = (int)Colour.BLACK;
                        y.NodeColour = (int)Colour.BLACK;
                        z.Parent.Parent.NodeColour = (int)Colour.RED;
                        z = z.Parent.Parent;

                    }
                    else
                    {
                        if (z == z.Parent.Left)
                        {
                            z = z.Parent;
                            RightRotate(ref z);
                        }

              
                            z.Parent.NodeColour = (int) Colour.BLACK;
                            z.Parent.Parent.NodeColour = (int) Colour.RED;
                            Node zl = z.Parent.Parent;
                            LeftRotate(ref zl);
                        
                    }
                }
            }

            root.NodeColour = (int)Colour.BLACK;
        }
        

        private readonly int space = 10;
        void draw_tree_hor2(Node tree, int distance)
        {
            if (tree == nil)
                return;

            distance += space;

            draw_tree_hor2(tree.Right, distance);


            Console.Write("\n");

            for (int i = space; i < distance; i++)
                Console.Write(" ");
            Console.Write(tree.Name+":");
            if (tree.NodeColour == (int)Colour.BLACK)
                Console.Write("+");

            Console.Write(tree.Key + "\n");

            draw_tree_hor2(tree.Left, distance);
        }


        void draw_tree_hor(Node tree)
        {
            draw_tree_hor2(tree, 0);
        }


        void RB_Transplant(Node u, Node v)
        {
            if (u.Parent == nil)
                root = v;
            else if (u == u.Parent.Left)
                u.Parent.Left = v;
            else
                u.Parent.Right = v;
            v.Parent = u.Parent;

        }


        void RB_Delete(Node root,string name)
        {
            Node z = Inorder_FindNode(root, name);
            Node y = z;
            Node x;
            int y_original_color = y.NodeColour;
            if (z.Left == nil)
            {
                x = z.Right;
                RB_Transplant(z, z.Right);
            }
            else if (z.Right == nil)
            {
                x = z.Left;
                RB_Transplant(z, z.Left);

            }
            else
            {
                y = Tree_Minimum(z.Right);
                y_original_color = y.NodeColour;
                x = y.Right;
                if (y.Parent == z)
                    x.Parent = y;
                else
                {
                    RB_Transplant(y,y.Right);
                    y.Right = z.Right;
                    y.Right.Parent = y;

                }
                RB_Transplant(z,y);
                y.Left = z.Left;
                y.Left.Parent = y;
                y.NodeColour = z.NodeColour;


            }
            if(y_original_color == (int)Colour.BLACK)
                RB_Delete_Fixup(ref x);

        }
        

        private void RB_Delete_Fixup(ref Node x)
        {
       
            Node par;
            while (x != root && x.NodeColour == (int) Colour.BLACK)
            {
                if (x == x.Parent.Left)
                {
                    Node w = x.Parent.Right;
                    if (w.NodeColour == (int) Colour.RED)
                    {
                        w.NodeColour = (int) Colour.BLACK;
                        x.Parent.NodeColour = (int) Colour.RED;
                        par = x.Parent;
                        LeftRotate(ref par);
                        w = x.Parent.Right;
                    }

                    if (w.Left.NodeColour == (int) Colour.BLACK && w.Right.NodeColour == (int) Colour.BLACK) //Drugi przypadek
                    {
                        w.NodeColour = (int) Colour.RED;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Right.NodeColour == (int) Colour.BLACK)
                        {
                            w.Left.NodeColour = (int) Colour.BLACK;
                            w.NodeColour = (int) Colour.RED;
                            RightRotate(ref w);
                            w = x.Parent.Right;
                        }

                    w.NodeColour = x.Parent.NodeColour;
                    x.Parent.NodeColour = (int) Colour.BLACK;
                    w.Right.NodeColour = (int) Colour.BLACK;
                    par = x.Parent;
                    LeftRotate(ref par);
                    x = root;

                }
            }

            else
                {
                    Node w = x.Parent.Left;
                    if (w.NodeColour == (int)Colour.RED)
                    {
                        w.NodeColour = (int)Colour.BLACK;
                        x.Parent.NodeColour = (int)Colour.RED;
                        par = x.Parent;
                        RightRotate(ref par);
                        w = x.Parent.Left;
                    }

                    if (w.Right.NodeColour == (int)Colour.BLACK && w.Left.NodeColour == (int)Colour.BLACK)
                    {
                        w.NodeColour = (int)Colour.RED;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Left.NodeColour == (int) Colour.BLACK)
                        {
                            w.Right.NodeColour = (int) Colour.BLACK;
                            w.NodeColour = (int) Colour.RED;
                            LeftRotate(ref w);
                            w = x.Parent.Left;
                        }

                        w.NodeColour = x.Parent.NodeColour;
                        x.Parent.NodeColour = (int) Colour.BLACK;
                        w.Left.NodeColour = (int) Colour.BLACK;
                        par = x.Parent;
                        RightRotate(ref par);
                        x = root;
                    }

                }
            }

            x.NodeColour = (int) Colour.BLACK;
        }

        Node Tree_Minimum(Node x)
        {
            while (x.Left != nil)
                x = x.Left;
            return x;
        }
        Node Tree_Maximum(Node x)
        {
            while (x.Right != nil)
                x = x.Right;
            return x;
        }

        int Count_Red_Nodes(ref Node root,ref int number_of_red_nodes)
        {
            if (root != nil)
            {
                Node left = root.Left;
                Count_Red_Nodes(ref left,ref number_of_red_nodes);
               if(root.NodeColour == (int)Colour.RED)
                    number_of_red_nodes++;
                Node right = root.Right;
                Count_Red_Nodes(ref right,ref number_of_red_nodes);

            }

            return number_of_red_nodes;

        }




        int minimumDepth(Node root)
        {
            if (root == nil)
            {
                return 0;
            }
            if (root.Left == nil && root.Right == nil)
            {
                return 1;
            }
            if (root.Left == nil)
            {
                return minimumDepth(root.Right) + 1;
            }
            if (root.Right == nil)
            {
                return minimumDepth(root.Right) + 1;
            }
            return Math.Min(minimumDepth(root.Right), minimumDepth(root.Right)) + 1;
        }

        int maxDepth(Node root)  
        { 
            if (root==nil)  
                return 0; 
            else 
            { 
                int lDepth = maxDepth(root.Left);
                int rDepth = maxDepth(root.Right); 
                if (lDepth > rDepth)  
                    return(lDepth+1); 
                else return(rDepth+1); 
            }
        }  
        /*
        void BST_insert(ref Node z)
        {
            Node x = root;

            Node y = nil;

            while (x != nil)
            {
                y = x;
                if (z.Key < x.Key)
                    x = x.Left;
                else
                    x = x.Right;
            }
            z.Parent = y;
            if (y == nil)
                root = z;
            else if (z.Key < y.Key)
                y.Left = z;
            else
                y.Right = z;
            
        }
        
        void RB_insert(ref Node z)
        {
            BST_insert(ref z);
            z.NodeColour =(int)Colour.RED;
            Node y;
            while (z != root && z.Parent.NodeColour == (int)Colour.RED)
            {
                if (z.Parent == z.Parent.Parent.Left)
                {
                    y = z.Parent.Parent.Right;
                    if (y.NodeColour == (int)Colour.RED)
                    {
                        z.Parent.NodeColour = (int)Colour.BLACK;
                        y.NodeColour = (int)Colour.BLACK;
                        z.Parent.Parent.NodeColour = (int) Colour.RED;
                        z = z.Parent.Parent;
                    }
                    else if (z == z.Parent.Right)
                    {
                        z = z.Parent;
                        LeftRotate(ref z);
                    }

                    z.Parent.NodeColour = (int) Colour.BLACK;
                    z.Parent.Parent.NodeColour = (int) Colour.RED;
                    Node zp = z.Parent.Parent;
                    RightRotate(ref zp);
                }
                else
                {
                    y = z.Parent.Parent.Left;
                    if (y.NodeColour== (int)Colour.RED)
                    {
                        z.Parent.NodeColour = (int) Colour.BLACK;
                        y.NodeColour = (int) Colour.BLACK;
                        z.Parent.Parent.NodeColour = (int)Colour.RED;
                        z = z.Parent.Parent;
                    }
                    else if (z == (z.Parent.Left))
                    {
                        z = z.Parent;
                        RightRotate(ref z);
                    }

                    Console.WriteLine("Root:"+root.Key);
                    Console.WriteLine("z.key "+z.Key);
                    z.Parent.NodeColour = (int)Colour.BLACK;
                    z.Parent.Parent.NodeColour = (int)Colour.RED;
                    Node zp = z.Parent.Parent;
                    LeftRotate(ref zp);

                }

                
            }
            root.NodeColour = (int)Colour.BLACK;

        }


    */


    }


}
