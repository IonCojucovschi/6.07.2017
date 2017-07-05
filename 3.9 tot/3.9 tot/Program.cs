using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9_tot
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,c;
           
            Console.WriteLine("Introduce string:");s = Console.ReadLine();
            Console.WriteLine("Introduce char:"); c = Console.ReadLine();
            s = s.Replace(c, "");

            Console.WriteLine("Sring is : {0}",s);
            Console.ReadLine();

        }
    }
}
