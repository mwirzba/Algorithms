using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            string one= " heheheeqawd";
            string two= " heheasdasf";
            NWD nwd = new NWD();
            nwd.LCS_Length(one, two);
            one = "xabbaac";
            two = "xbacbacba";
            Console.WriteLine();
            nwd.LCS_Length(one, two);

            Console.ReadKey();
        }
    }
}
