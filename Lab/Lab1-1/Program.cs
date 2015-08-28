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
            int count = 0;
            
         
            int[] input = { 9,2,7,6,1,2 };
           
            // process
            for (int j =0;j< input.Length; j++)
            {
                
                for (int i = 0; i != input.Length - 1; i++)
                {
                    count++;
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    
                    }
                }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
            Console.Write("Loop :" + count);
            Console.ReadKey();
        }
    }
}
