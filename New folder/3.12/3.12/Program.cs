using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,s1="";
            Console.WriteLine("Introduce Stringul dat :"); s = Console.ReadLine();
            int a, b,suma=0;
            char zero =Char.Parse( "0"), nine = Char.Parse("9");
            a = zero;
            b = nine;

            for(int i = 0; i < s.Length; i++)
            {
                if((int)s[i]>a & (int)s[i] < b) { s1 += s[i]; }
            }
            for(int i = 0; i < s1.Length; i++)
            {
                String z = "" + s1[i];
                suma += Int32.Parse(z);
            }

            Console.WriteLine("Summ of numbers is : {0}",suma);


            Console.ReadLine();
        }
    }
}
