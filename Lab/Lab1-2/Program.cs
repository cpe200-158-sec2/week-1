using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {

        static List<int> inputs = new List<int>();

        static void Main(string[] args)
        {

            Input();
            Process();
            Output();
            
        }

        private static void Process()
        {
            bool flag = true;

            // process
            while (flag)
            {
                flag = false;
                for (int i = 0; i != inputs.Count - 1; i++)
                {
                    if (inputs[i] > inputs[i + 1])
                    {
                        int temp = inputs[i];
                        inputs[i] = inputs[i + 1];
                        inputs[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }

        private static void Output()
        {
            // output
            for (int i = 0; i < inputs.Count; i++)
            {
                Console.Write(inputs[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

        private static void Input()
        {
            // input
            String input = Console.ReadLine();
            int number = 0;
            int shit = 1;
            while (!input.Equals("exit"))
            {
                if ((Int32.TryParse(input, out shit) ))
                {
                    number = int.Parse(input);
                   
                    inputs.Add(number);
                 
                }

                input = Console.ReadLine();


            }
            //Console.WriteLine(tmp)
        }
    }
}
