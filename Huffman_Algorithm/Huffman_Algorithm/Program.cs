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
             huffman.Huffman("numbers.txt");

            Console.ReadKey();


        }
    }
}
