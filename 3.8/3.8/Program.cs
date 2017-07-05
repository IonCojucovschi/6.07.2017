using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,s2="",s3="";
            char g;
            Console.WriteLine("Introduce text:");s = Console.ReadLine();
            Console.WriteLine("Introduce a character:"); g = Char.Parse(Console.ReadLine());
            s2 = s2+g + g;
            s3 = s3+g;
            s = s.Replace(s3, s2);
            Console.WriteLine("Text is {0}:", s);
            Console.ReadLine();
        }
    }
}
