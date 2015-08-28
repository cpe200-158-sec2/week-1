using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static int[] input2()
+        {
+            int size;
+            Console.Write("Enter size: ");
+            size = int.Parse(Console.ReadLine());
+            int[] ins = new int[size];
+            for (int i = 1; i <= size; i++)
+            {
+                Console.Write(i + ": ");
+                ins[i - 1] = int.Parse(Console.ReadLine());
+            }
+            return ins;
+        }
+        static void process(ref int[] input)
    {
            bool flag = true;

            // input
          

            // process
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

        // output
    }
+        static void output(ref int[] input)
+        {
+            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
  }
+        static void Main(string[] args)
+        {
+           
+            // input
+            int[] input = input2();
+
+            // process
+            process(ref input);
+
+            // output
+            output(ref input);
Console.ReadKey();
        }
    }
}
