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
            
            int n;
            Console.Write("total number : ");
            n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i< n;i++)
            {
                Console.Write("Enter number : ");
                input[i]= int.Parse(Console.ReadLine());
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
            Console.Write("Answer larger to smaller : ");
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
