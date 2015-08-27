﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        public static int[] inp()
        {
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return input;
        }

        public static void pro(int[] input)
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

            public static void outp(int[] input)
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
                int[] input = inp();
                pro(input);
                outp(input);
            }
     }
}
