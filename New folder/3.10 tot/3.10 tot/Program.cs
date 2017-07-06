using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_tot
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,sub;
            Console.WriteLine("Introduce text:");s = Console.ReadLine();
            Console.WriteLine("Introduce substring text:"); sub = Console.ReadLine();
            s = s.Replace(sub,"");
            Console.WriteLine("Neew string is :{0}",s);
            Console.ReadLine();
        }
    }
}
