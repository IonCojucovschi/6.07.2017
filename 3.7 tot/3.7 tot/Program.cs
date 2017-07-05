using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_tot
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i, j;
            Console.WriteLine("INtroduce string: ");s = Console.ReadLine();
            if (s.Length % 2 == 0) { s = s.Substring(0, (s.Length / 2) - 1) + s.Substring((s.Length / 2) + 1, (s.Length / 2) - 1); }
            else { s = s.Substring(0, (s.Length / 2)) + s.Substring((s.Length / 2)+1, s.Length / 2); }
            Console.WriteLine(s);


            Console.ReadLine();
           



        }
    }
}
