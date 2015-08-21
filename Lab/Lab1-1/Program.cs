using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            bool flag = true;

            // input
            int[] input = { 1, 2, 3,4, 5, 6, 7, 8,9,10 };
            int c=0;
            // process
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    c++;
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                    for (int j = 0; j != input.Length; j++)
                    {
                        Console.Write(input[j]);
                        Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.Write(c);
            Console.ReadKey();
        }
    }
}
