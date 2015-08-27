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
            int[] input = inputfx();
            int[] process = processfx(input);
            outputfx(process);

        }


        // input
        static int[] inputfx()
        {
           
            Console.WriteLine("how many your number ? : ");
            int num = int.Parse(Console.ReadLine());

            int[] input = new int[num];

            for (int i=0; i !=input.Length ;i++)
            {
                Console.WriteLine("Input your number : ");
                input[i] = int.Parse(Console.ReadLine());

            }

         
            return input;
        }
                

    // process
    static int[] processfx(int[] a)
    {

        int[] input = a;

        for (int j = 0; j <= input.Length - 1; j++)
        {

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[j] > input[i])
                {
                    int temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;

                }
            }
        }
        return input;
    }
    // output
    static void outputfx(int[] a)
    {
            int[] input = a;
        
        for (int i = 0; i != input.Length; i++)
        {
            Console.Write(input[i]);
            Console.Write(" ");
        }
        Console.ReadKey();
    }

}
}
    

