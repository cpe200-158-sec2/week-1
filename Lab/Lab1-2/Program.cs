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
            static int[] input()
         {
                bool flag = true;
                int x;
                Console.WriteLine("Input many number :");
                x = Convert.ToInt32(Console.ReadLine());
                int[] z = new int[x];


                for (int i = 0; i < x; i++)
                {
                    int y = i + 1;
                    Console.WriteLine("number" + y);

                    // input
                    int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
                    int e = Convert.ToInt32(Console.ReadLine());
                    z[i] = e;
                }
                return x;
            }

            static int[] process(int[] input)
                    {
                bool flag = true;

                // process
                while (flag)
                {
                    flag = false;

                    static void Main(string[] args)

                        }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);

                return input;
            }

            static void output(int[] number)
                {
                foreach (int i in number)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                Console.ReadKey();
            }

            static void Main(string[] args)
                {
                output(process(input()));

            }
        }
    }
