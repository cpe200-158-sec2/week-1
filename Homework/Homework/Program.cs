using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static int process(int i)
        {
            int result;
            if(i > 1)
            {
                result = i * process(i - 1);
            } else
            {
                result = 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Input Your Numbers For process : ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Number output : ");
            Console.Write(process(i));
            Console.ReadKey();
        }
        

    }
}
