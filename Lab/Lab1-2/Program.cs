using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1_2
{
    class BubbleSortFunction
    {
        public static int[] input_func(int[] a)
        {
            for (int i = 0; i != 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        public static void process_func(int[] a)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        flag = true;

                    }
                }
            }
        }
        public static void output_func(int[] a)
        {
            for (int i = 0; i != a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int[] input = new int[10];
            input_func(input);
            process_func(input);
            output_func(input);
            

        }
    }
}
