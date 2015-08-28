# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 713b1850221ef1787cb6c1cd9ee5b80d41ce8fc0
* Without flag:8c6933be8194594f78fba350232131fc15164779

## Questions
1. How this code can sort number from smaller to larger
 
Answer: this code use bubblesort way.its have bool to select the case of the number.if the number is larger than each one.the bool will go false.and when its false.its will get in to for loop to do the process.at the end of the solution the bool will change to true. 


2. What if two numbers equal, what will happen? 

Answer:  its will go to the next number.its will not get in a if loop. 

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 times
 
4. Why we need flag variable ? 

Answer:  to choose the case of number to the next step.to get in a loop or to get out a loop.


5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:if we remove flag.the information that done before.it will make the process slower and it will go faster if dont have while loop. 
