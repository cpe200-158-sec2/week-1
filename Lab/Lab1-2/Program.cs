using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {


        //input 
        public static int[] inPut()
        {
            Console.WriteLine("-----Enter Max of Number-----");
            int loop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----Enter Number -----");
            int[] num = new int[loop];
            for (int i = 0; i < loop; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        //procees function
        public static void bbSrt(int[] input)
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
        //output
        public static void outPut(int[] input)
        {
            Console.WriteLine("-----Sort Lowest to Hightest-----");
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
            
            int[] input = inPut();
            // process
            bbSrt(input);

            // output
            outPut(input);
        }
    }
}
