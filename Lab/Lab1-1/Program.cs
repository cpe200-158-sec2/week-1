﻿using System;
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
            //int count = 0;
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // process
            for (int x = 0; x < input.Length ; x++)
            {
                //count++;
                for (int i = 0; i != input.Length - 1; i++)
                {
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
            Console.ReadKey();
           // Console.Write(count);
        }
    }
}
