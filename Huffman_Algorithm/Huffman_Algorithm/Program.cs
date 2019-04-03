using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm huffman = new Algorithm();
             huffman.Huffman("numbers.txt",true);
            Algorithm huffman2 = new Algorithm();

            huffman2.Huffman("numbers.txt", false);

            Console.ReadKey();


        }
    }
}
