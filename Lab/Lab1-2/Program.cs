using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        
        static int[] inputt()
        {
         
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            int[] input = new int[size];
            for (int i=0; i < size; i++)
            {
                Console.Write("Enter number: ");
                input[i] = int.Parse(Console.ReadLine());
            }


            return input;
        }

        static int[] process (int[] a)
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

            return a;
        }

        static void output (int[] a)
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

            int[] intt = inputt();
            process(intt);
            output(intt);
          
        }
    }
}
