using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            String s,inter,characters="",NulStr="";
            char c;
            int j = 0;
            Console.Write("Introduce Text: "); s = Console.ReadLine();
            inter = s;
            
            for (int i = 0; i < inter.Length; i++)
            {
                NulStr=""+inter[i];
                characters += inter[i]; inter = inter.Replace(NulStr,"");
            }

            s = characters + s;
            Console.Write("Characters before string are {0}, and string is {1}",characters,s); 



            Console.ReadLine();
        }
    }
}
