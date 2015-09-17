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
            outputFunction(processFunction(inputFunction()));
            
        }



        static int[] inputFunction()
        {
            int input[] = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
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

        static int[] processFunction(int[] inputnumber)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != inputnumber.Length - 1; i++)
                {
                    if (inputnumber[i] > inputnumber[i + 1])
                    {
                        int temp = inputnumber[i];
                        inputnumber[i] = inputnumber[i + 1];
                        inputnumber[i + 1] = temp;
                        flag = true;
                    }
                }
            }

            return inputnumber;
        }

        static int[] outputFunction(int[] output)
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