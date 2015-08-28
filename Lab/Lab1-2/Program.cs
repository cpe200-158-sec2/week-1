using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {

        // input
        static int[] input()
        {
            int[] c=new int[10];
            for (int i = 0; i <10; i++)
            {
               c[i] = int.Parse(Console.ReadLine());
            }
               
            return c;
        }
        
        // process
        static void process(int []a)
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
           
            }

        // output
        static void output(int []b)
        {
             for (int i = 0; i != b.Length; i++)
                {
                    Console.Write(b[i]);
                    Console.Write(" ");
                }
        }
           

        static void Main(string[] args)
        {

            int[] c = input();
            process(c);
            output(c);
            Console.ReadKey();
        }
    }
}
