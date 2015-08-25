using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input2()
        {
            int[] ins= { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return ins;
        }
        static void process(ref int[] input)
        {
            bool flag = true;

            while (flag)
            {

                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }

        }
        static void output(ref int[] input)
        {
            for (int i = 0; i != size; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
           
            // input
            int[] input = input2();

            // process
            process(ref input);

            // output
            output(ref input);
            Console.ReadKey();
        }
    }
}
