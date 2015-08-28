using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input()
        {
            Console.Write("How many number do you want to sort ?: ");
            int num = int.Parse(Console.ReadLine());
            int[] input = new int[num];
            for(int i=0; i != input.Length;i++)
            {
                Console.Write("Number {0} is: ",i+1);
                input[i] = int.Parse(Console.ReadLine());
            }
            return input; 
        }
        static void process(int[] a)
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
        static void output(int[] b)
        {
            Console.Write("Result: ");
            for (int i = 0; i != b.Length; i++)
            {
                Console.Write(b[i]);
                Console.Write(" ");
            }
        }

        static void Main(string[] args)
        {
            int[] x = input();
            process(x);
            output(x);
            Console.ReadKey();
        }
    }
}
