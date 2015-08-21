# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:a3da2291c48cb537b6b90b4e048f4e6a24531b65
* Without flag:c3b77c621cec1c64209415882df79d593481aa19

## Questions
1. How this code can sort number from smaller to larger
 
Answer: This code check each index of array if it's less than the next index, It gonna swap with the next index, and do until end of first loop,
		Then it gonna while loop until condition in for loop is all false, so done and print out.

2. What if two numbers equal, what will happen? 

Answer: Nothing happen.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n(n-1) , as n is array's length.

4. Why we need flag variable ? 

Answer: Flag variable can check if condition code is true, that's mean there are unsorted numbers.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Slower, because code have to run maximum possibility of loop(array's lenght - 1).
