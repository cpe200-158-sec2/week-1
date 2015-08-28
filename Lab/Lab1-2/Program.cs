using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input;
        static void Main(string[] args)
        {
            int l;
            Console.Write("How many number : ");
            l = Convert.ToInt32(Console.ReadLine());
            input = new int[l];
            
            // input
            Input();
            // process
            Process();
            // output
            Output();
        }
        static public void Input()
        {

            for (int i = 0; i != input.Length; i++)
            {
                Console.Write("Input Number : ");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static public void Process()
        {
            bool flag = true;
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

        }
        static public void Output()
        {
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
