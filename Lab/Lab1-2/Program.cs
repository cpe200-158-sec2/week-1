using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1_1
{
    class BubbleSort
    {
        static void Main(string[] args)
        {


            int[] int2 = input1();
            processic(int2);
            pim(int2);
            
            
        }

        static int[] input1()
        {
            Console.WriteLine("Plaese in put your number ...");
            int n = int.Parse(Console.ReadLine());
            int [] mydata = new int[n];
            for (int i = 0; i < n; i++) 
            {
                Console.Write("ENTER ", 1);
                    mydata[i] = int.Parse(Console.ReadLine());

            }
            
                //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            return mydata;

        }

       static void pim (int[] b)
        {
        for (int i = 0; i != b.Length; i++)
    {
            Console.Write(b[i]);
            Console.Write(" ");
    }
        Console.ReadKey();
        }


        static void processic(int[] a)
    {
        for (int k = 0; k != a.Length - 1; k++)
        {

            for (int i = 0; i != a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;

                }


            }


        }
    }

}
}