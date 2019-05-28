using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsInTextAlgorithms
{
    public class Algorithms
    {
        public void Naive(string pattern, string text)
        {
          
            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                int j = 0;
                for (j = 0; j < pattern.Length; j++)
                    if (text[i + j] != pattern[j])
                        break;
                if (j == pattern.Length)
                    Console.WriteLine("Znaleziono wzorzec na pozycji " + i);
            }

        }

        public void Rabin_Karp(string pattern, string text,int d,int q)
        {
            int hash = 1;
            for (int i = 0; i < pattern.Length-1; i++)
                hash = (hash * d) % q;

            int patternH = 0;
            int currTextH = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                patternH = (d * patternH + pattern[i]) % q;
                currTextH = (d * currTextH + text[i]) % q;
            }

            for (int i = 0; i < text.Length-pattern.Length; i++)
            {
                if (patternH == currTextH)
                {
                    int j = 0;
                    for (j = 0; j < pattern.Length; j++)
                    {
                        if (text[i + j] != pattern[j])
                            break;
                    }

                    if (j == pattern.Length)
                        Console.WriteLine("Znaleziono wzorzec na pozycji " + i);
                }

                if (i < text.Length - pattern.Length)
                {
                    int newHash = (text[i] * hash) % q;
                    if (currTextH < newHash)
                    {
                        currTextH = currTextH + q;
                    }

                    currTextH = (d * (currTextH - newHash) + text[i + pattern.Length]) % q;
              
                }
            }
        }


        public void KMP(string text, string pattern)
        {
            int q = 0;
            int[] prefixTable = Prefix_Function(pattern);
            int patternIterator = 0; // pattern index
            int textIterator = 0; // text index

            while (textIterator < text.Length)
            {
                if (pattern[patternIterator] == text[textIterator])
                {
                    patternIterator++;
                    textIterator++;
                }
                if (patternIterator == pattern.Length)
                {
                    Console.WriteLine("Znaleziono wzorzec na pozycji " + (textIterator - patternIterator));
                    patternIterator = prefixTable[patternIterator - 1];
                }

                else if (textIterator < text.Length && pattern[patternIterator] != text[textIterator])
                {

                    if (patternIterator != 0)
                        patternIterator = prefixTable[patternIterator - 1];
                    else
                        textIterator = textIterator + 1;
                }
            }


        }

        private int[] Prefix_Function(string pattern)
        {
            int len = 0;
            int i = 1;
            int[] prefixTable =  new int[pattern.Length];
            prefixTable[0] = 0; 

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    prefixTable[i] = len;
                    i++;
                }
                else
                {
        
                    if (len != 0)
                    {
                        len = prefixTable[len - 1];

                    }
                    else 
                    {
                        prefixTable[i] = len;
                        i++;
                    }
                }
            }
            return prefixTable;
        }
    }
}
