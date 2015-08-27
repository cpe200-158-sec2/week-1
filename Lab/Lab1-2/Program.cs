using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {

        public static double[] inputNUM()
        {
            Console.Write("Enter the total number of elements : ");
            int max = Convert.ToInt32(Console.ReadLine());
            double[] num = new double[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("Enter [" + (i + 1).ToString() + "] element : ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }
            return num;
        }

        public static void process(double[] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        double temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }

        public static void output(double[] input)
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
            // input
            double[] input = inputNUM();
            // process
            process(input);
            // output
            output(input);
        }
        

    }
}
