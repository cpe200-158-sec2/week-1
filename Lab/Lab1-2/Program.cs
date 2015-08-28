using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] source;
        static void Main(string[] args)
        {
            source = new int[10];
            input();
            process();
            output();
        }
        static public void input()
        {
            int i;
            for (i = 0; i < 10; i++)
                source[i] = Convert.ToInt32(Console.ReadLine());
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
