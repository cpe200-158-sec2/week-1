# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: b6fa5e5741ee58a7003eddc3fc02a78ff2940259
* Without flag: 14c196074e239a0e7b3447d26253d428221bc32f

## Questions
1. How this code can sort number from smaller to larger
 
Answer: It's compare each couple of int in order. If the first one is smaller than the second. 
		It will swap the value of both ints. And do this process to every pair of ints until the end of the input.

2. What if two numbers equal, what will happen? 

Answer: Nothing. Both value still be the same. Only the value _i of for loop will increasing by one. 
		So the program will continue compare for the next pair of ints.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: Executed n(n-1)/2 times.

4. Why we need flag variable ? 

Answer: For stopping the loop. When input reached its end. And no more int that larger than the lastest int. 
		The _flag won't change its value to true.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: No _flag, no stop looping.