﻿# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: dc0e6afef789d99857491d6513775da17eb2b5bc
* Without flag: f08da22f9a8c3c6f61c50e9ee9f2f0e5f28be827

## Questions
1. How this code can sort number from smaller to larger
 
Answer: ไล่เช็คทีละตำแหน่งในarray ถ้าเจอค่าที่มากกว่าตำแหน่งถัดไปจะสลับตำแหน่งกันกับตำแหน่งถัดไป ทำไปเรื่อยๆจนกว่าจะเรียงได้ครบทุกตัว

2. What if two numbers equal, what will happen? 

Answer: ข้ามไปคิดตัวถัดไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1,(n-1)^2]

4. Why we need flag variable ? 

Answer: เพื่อทำให้โปรแกรมสามารถวนเข้าloopแล้วทำงานได้จนจบ

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:	ทำงานช้ากว่าเดิม