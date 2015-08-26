using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        
        static int[] inputt()
        {
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
           
            return input;
        }

        static int[] process (int[] a)
        {
           
             bool flag = true;
             while (flag)
            {
                flag = false;
                for (int i = 0; i != a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        flag = true;
                    }
                }
            }

            return a;
        }

        static void output (int[] a)
        {
            for (int i = 0; i != a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
        

        static void Main(string[] args)
        {

            int[] intt = inputt();
            process(intt);
            output(intt);
          
        }
    }
}
