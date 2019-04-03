using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    internal class NWD
    {
        public void LCS_Length(string x, string y)
        {
            int[,] c = new int[x.Length, y.Length];
            int[,] b = new int[x.Length, y.Length];

            for (int i = 1; i < x.Length; i++)
            {
                for (int j = 1; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i, j] = '\\';
                    }
                    else
                    {
                        if (c[i - 1, j] >= c[i, j - 1])
                        {
                            c[i, j] = c[i - 1, j];
                            b[i, j] = '|';
                        }
                        else
                        {
                            c[i, j] = c[i, j - 1];
                            b[i, j] = '-';
                        }
                    }
                }
            }
            //int[][,] r = new int[2][,] { c, b };
            PrintLCS(x, y, b, x.Length - 1, y.Length - 1);
        }

        public void PrintLCS(string x, string y, int[,] b, int i, int j)
        {

            if (i == 0 || j == 0)
                return;
            if (b[i, j] == '\\')
            {
                PrintLCS(x, y, b, i - 1, j - 1);
                Console.Write(x[i]);
            }
            else
            {
                if (b[i, j] == '|')
                    PrintLCS(x, y, b, i - 1, j);
                else
                    PrintLCS(x, y, b, i, j - 1);
            }

        }
    }
}

