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
            string myInput;
            int Num;
            Console.Write("Input number: ");
            myInput = Console.ReadLine();
            Num = Int32.Parse(myInput);                      Console.WriteLine(process(Num));
            Console.ReadKey();
        }
    }
}
