# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:2c728b2b9ed6ae328ec06a29d6ff9bc36ce9fdb5
* Without flag:c9da3557eff7947e765af8db83574357cf1610c2

## Questions
1. How this code can sort number from smaller to larger
 
Answer: It'll swap if the right-hand side number is greater than left-hand side until there is no greater number on the right-hand side, the program stops.

2. What if two numbers equal, what will happen? 

Answer: The program just skip. Nothing happened.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: O(n log n)

4. Why we need flag variable ? 

Answer: To terminate program when there is no swap occur.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:
