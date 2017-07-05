using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajutor_pu_problema_2._3
{
    class Program
    {
        public static void VertorDell(int[,] a,int l,int c, ref int[] q)
        {
            int i, j, k=0,index=0;
            for (i = 0; i < l; i++)
            {
                for (j = 0; j < c; j++)
                {
                    if (a[i, j] == a[i, j + 1]) { k++; }
                }
                if (k == c-1) { q[index] = 1;index++; }else { q[index] = 0;index++; }
                k = 0;
            }

        }
        static void Main(string[] args)
        {
            int[,] a;
            int[] q;
            int l, c;
            Console.WriteLine("nr de linii :");    l=Int32.Parse(Console.ReadLine());
            Console.WriteLine("nr de coloane :"); c = Int32.Parse(Console.ReadLine());
            a = new int[l, c+2];
            q = new int[l];
                       Random r = new Random();
            for (int i = 0; i < l; i++)
            {
                q[i] = 0;
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = r.Next(2, 10);

                }
                
            }

            for (int j = 0; j < c; j++)
            {
                a[2, j] = 2;
                a[4, j] = 3;
            }
            /////////////////////////////
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(" {0}",a[i, j]);

                }
                Console.WriteLine();
            }
            ////////////////////////////
            VertorDell(a, l, c, ref q);

            for(int i = 0; i < l; i++)
            {
                Console.Write(" {0}", q[i]);
            }

            Console.Read();


        }
    }
}
