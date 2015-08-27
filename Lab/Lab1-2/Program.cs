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
            Console.WriteLine("How many size of number?: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int[] input = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine((i + 1) + ": ");
                input[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                }
            return input;
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
            Console.WriteLine("The result: ");
            outputfunc(input);
        }
    }
}
