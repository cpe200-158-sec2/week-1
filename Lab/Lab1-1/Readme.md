# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: compare numbers 1 by 1 from input array , first position in array to last.

2. What if two numbers equal, what will happen? 

Answer: which one come first go to first.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n*(n-1)

4. Why we need flag variable ? 

Answer: to check that already sorted.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: slower cause it need to check condition in every numbers. if use flag , just check this variable that follow the condition.