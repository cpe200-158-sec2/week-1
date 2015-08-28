using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        public static void process(int[] input)
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

        public static int[] inp()
        {
            Console.Write("Enter total num : ");
            int total = int.Parse(Console.ReadLine());
            int[] num = new int[total];
            for(int i=0; i<total; i++)
            {
                Console.Write("Number " + (i + 1) + " equl = ");
                num[i] = int.Parse(Console.ReadLine());
            }
            return num;
        }

        public static void output(int[] input)
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
            int[] inputs = inp();
            process(inputs);
            output(inputs);
        }
    }
}

    