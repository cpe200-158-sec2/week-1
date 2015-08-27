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
            Console.Write("How many numbers will be sorted?\n");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] input = new int[x];

            for (int i = 0; i != input.Length; i++)
            {
                Console.Write("Enter number : ");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
           

            bool flag = true;

            

            // process
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

            // output
            Console.Write("Sorted from lesser to greater number.\n");
            for (int i = 0; i != input.Length; i++) 
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
