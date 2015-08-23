/*
 * Created by SharpDevelop.
 * User: Recurring
 * Date: 8/23/2015
 * Time: 10:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

// Program start class
namespace Lab1_2
{
class BubbleSortFunction
    {
	static void Main(string[] args)
        {
        	Input();
        }
/// //////////////////////////////////////
	static void Input(){
            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            process(input);
        }
     /////////////////////////////////   
	static void process(int[] input){
            // process
            bool flag = true;
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
            output(input);
        }
       /////////////////////////////////
	static void output(int[] input){
            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
