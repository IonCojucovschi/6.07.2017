using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            char c;
            int j=0;
            Console.Write("Introduce Text: ");s = Console.ReadLine();
            Console.Write("Introduce Character: "); c = Char.Parse(Console.ReadLine());


            int[] indexes = new int[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) { indexes[j] = i;j++; }
            }
            Console.WriteLine("First index ocurence of character {0} is {1} and last index ocurence is {2}",c,indexes[0],indexes[j-1]);

            Console.ReadLine();
        }
    }
}
