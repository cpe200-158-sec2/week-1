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

            int[] y = input();
            process(y);
            output(y);
            Console.ReadKey();
        }

        // input
        static int[] input()
     {
            
            Console.WriteLine("Plaese in put your number ...");
            int n = int.Parse(Console.ReadLine());
            int[] mydata = new int[n];
                        for (int i = 0; i < n; i++)
                            {
                Console.Write("ENTER ", 1);
                mydata[i] = int.Parse(Console.ReadLine());
                
                            }
            //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            return mydata;
       }
       
       // process
      static void process(int[] y)
    {
        bool flag = true;
        while (flag)
        {
            flag = false;
                for (int i = 0; i != y.Length - 1; i++)
                {
                    if (y[i] > y[i + 1])
                    {
                        int temp = y[i];
                        y[i] = y[i + 1];
                        y[i + 1] = temp;
                        flag = true;
                    }
                }
            }

        }
        // output
        static void output(int[] y)
        {
            for (int i = 0; i != y.Length; i++)
            {
                Console.Write(y[i]);
                Console.Write(" ");
            }
        }

    }
    }
