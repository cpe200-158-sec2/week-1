using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {

            int[] y = input();
            process(y);
            output(y);
            Console.ReadKey();
        }

        // input
        static int[] input()
     {
            int[] x = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
          return x;
       }
       
       // process
      static void process(int[] y)
    {
        bool flag = true;
        while (flag)
        {
            flag = false;
                for (int i = 0; i != y.Length - 1; i++)
                {
                    if (y[i] > y[i + 1])
                    {
                        int temp = y[i];
                        y[i] = y[i + 1];
                        y[i + 1] = temp;
                        flag = true;
                    }
                }
            }

        }
        // output
        static void output(int[] y)
        {
            for (int i = 0; i != y.Length; i++)
            {
                Console.Write(y[i]);
                Console.Write(" ");
            }
        }

    }
    }
