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
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // process
            int i = 0;
            while (i != 10)
            {
              
                if (input[i] > input[i + 1])
                {Console.Write(input[i]);
                    Console.Write(" ");
                    int temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                    Console.Write("fuck ");
                    i++;
                    
                    
                        
                    
                }
            }


            // output
          
            Console.ReadKey();
        }
    }
}
