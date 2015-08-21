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

            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            int kuy = 0;

            // process
            for (int i = 0; i != input.Length - 1; i++)
            {
                for (int j = 0; j != input.Length - 1; j++)
                {
                    kuy++;
                    if (input[j] < input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.Write(kuy);
            Console.ReadKey();
        }
    }
}
