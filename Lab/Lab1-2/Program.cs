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
            outputfn(processfn(inputfn()));          
        }

        static int[] inputfn()
        {
            Console.Write("Size of numbers to input : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[size];

            Console.WriteLine("Enter numbers ");
            for (int i = 0; i < size; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }

            return input;
        }

        static int[] processfn(int[] num)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != num.Length - 1; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        int temp = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            return num;
        }

        static int[] outputfn(int[] output)
        {
            for (int i = 0; i != output.Length; i++)
            {
                Console.Write(output[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
            return output;
        }
        
    }
}
