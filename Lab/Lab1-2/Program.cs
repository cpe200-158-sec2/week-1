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
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
     
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
            return 0;
        }

        static int[] outputfn(int[] output)
        {
            for (int i = 0; i != output.Length; i++)
            {
                Console.Write(output[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
            return 0;
        }

    }
}
