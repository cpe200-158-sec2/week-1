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
            bool flag = true;

            // input
            int l;

            Console.Write("How many number : ");
            l = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[l];

            for (int i = 0; i != input.Length; i++)
            {
                Console.Write("Input Number : ");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            // process
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }

            // output
            Console.Write("Sort number larger to smaller : ");
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
