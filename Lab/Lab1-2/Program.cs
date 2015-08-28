using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] source = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
        static void Main(string[] args)
        {           
            input();
            process();
            output();
        }
        static public void input()
        {

        }

       static public void process()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != source.Length - 1; i++)
                {
                    if (source[i] > source[i + 1])
                    {
                        int temp = source[i];
                        source[i] = source[i + 1];
                        source[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        static public void output()
        {
            for (int i = 0; i != source.Length; i++)
            {
                Console.Write(source[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
