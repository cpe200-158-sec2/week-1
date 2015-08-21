# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:Commit 785e0668 
* Without flag:668b37c3

## Questions
1. How this code can sort number from smaller to larger
 
Answer: change from if(input[i]<input[i+1]) to if(input[i]>input[i+1])

2. What if two numbers equal, what will happen? 

Answer: same number not get swap

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27

4. Why we need flag variable ? 

Answer: check and swap agian

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: faster because will run without flag's loop but not complete sort number