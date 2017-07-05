using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_tot
{
    class Program
    {
        public static void LineDell(ref int[,] a, int l, int c, int index)
        {
            int i, j, k, m;
            for (i=index;i<l-1;i++)///////l-1
            {
                for (j=0;j<c;j++)
                {
                    a[i, j] = a[i + 1, j];
                }

            }
            for (j = 0; j < c; j++)
            {
                a[l-1, j] =0;
            }

        }
        public static void ColumnDell(ref int[,] a, int l, int c, int index)
        {
            int i, j, k, m;
            for (i =0; i < l - 1; i++)
            {
                for (j = index; j < c-1; j++)////////c-1
                {
                    a[i, j] = a[i, j+1];
                }

            }
            for (j = 0; j < c; j++)
            {
                a[j, c-1] = 0;
            }

        }
        static void Main(string[] args)
        {
            int[,] a;
            int i, j, k,lines,columns,indexI,indexJ;
            Console.WriteLine("Numbers of Line:"); lines = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Numbers of Columns:"); columns = Int32.Parse(Console.ReadLine());
            a = new int[lines, columns];
            Random r = new Random();

            for (i = 0; i < lines; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    a[i, j] = r.Next(0, 10);
                }
            }
            ///////////////////
            for (i = 0; i < lines; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write(" {0}", a[i, j]);
                }
                Console.WriteLine();
            }
            ////////////////////////////

            for (i = 0; i < lines; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    if (a[i, j] == 0) {
                        LineDell(ref a, lines, columns, i);
                        ColumnDell(ref a, lines, columns, j);
                        lines--;
                        columns--;
                    }
                }
            }

            /////////////////////////////
            for (i = 0; i < lines; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write(" {0}", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
