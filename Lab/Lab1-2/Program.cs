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

            // input
            int[] input = input_func();

            // process
            int[] Answer = process_func(input);

            // output
            output_func(Answer);
        }

        // input fucntion
        static public int[] input_func()
        {
            int[] a = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return a;
        }

        // process fucntion
        static int[] process_func(int[] x)
        {

            int[] input = x;

            for (int j = 0; j != input.Length - 1; j++)
            {
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    }
                }
            }
            return input;
        }

        // output fucntion
        static void output_func(int[] x)
        {
            int[] input = x;
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
