using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternsInTextAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithms algorithms  =  new Algorithms();

            Console.WriteLine("\nTEST2");
            string text = File.ReadAllText("tekst.txt").Replace("\n","");
            string pattern = File.ReadAllText("wzorzec.txt").Replace("\n", "");


            var watch = System.Diagnostics.Stopwatch.StartNew();
            algorithms.Naive(pattern,text);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu naiwnego: "+elapsedMs + " ms-->\n");


            watch.Reset();
            watch.Start();
            algorithms.Rabin_Karp(pattern,text,128,27077);
            watch.Stop();
            var rabinTime = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu Rabina Karpa: " + rabinTime + " ms-->\n");


            watch.Reset();
            watch.Start();
            algorithms.KMP(text, pattern);
            watch.Stop();
            var KMPTime = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu KMP: " + KMPTime + " ms-->\n");



            Console.WriteLine("\nTEST2");

             text = File.ReadAllText("tekst2.txt").Replace("\n", "");
             pattern = File.ReadAllText("wzorzec2.txt").Replace("\n", "");


            watch = System.Diagnostics.Stopwatch.StartNew();
            algorithms.Naive(pattern, text);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu naiwnego: " + elapsedMs + " ms-->\n");


            watch.Reset();
            watch.Start();
            algorithms.Rabin_Karp(pattern, text, 128, 27077);
            watch.Stop();
            rabinTime = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu Rabina Karpa: " + rabinTime + " ms-->\n");


            watch.Reset();
            watch.Start();
            algorithms.KMP(text, pattern);
            watch.Stop();
            KMPTime = watch.ElapsedMilliseconds;
            Console.WriteLine("\n<--Czas działana algorytmu KMP: " + KMPTime + " ms-->\n");


            Console.ReadKey();
        }


        
            
    }
}

