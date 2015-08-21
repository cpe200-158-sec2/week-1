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

            // process
                for (int i = 0; i != input.Length - 1; i++)
                {
                    for (int j=i+1 ; j!=input.Length; j++)
                    {
                        if (input[j] < input[i])
                        {
                            int temp = input[j];
                            input[j] = input[i];
                            input[i] = temp;
                        }
                    }
                    
                }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
