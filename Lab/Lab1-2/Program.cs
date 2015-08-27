using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        //input function
        public static int[] inputfunct()
        {
            int[] a = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return a;
        }

        //procees function
        public static void processfunc(int[] input)
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

        //output
        public static void outputfunc(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            // input
            int[] input = inputfunct();

            // process
            processfunc(input);

            // output
            outputfunc(input);
        }
    }
}
