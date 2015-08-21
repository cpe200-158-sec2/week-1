# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:5eb88cfa
* Without flag: d26ea14b

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เช็คสมาชิกในอาเรบ์ทุกตัวแรกว่ามีค่ามากกว่าตัวถัดไปหรือเปล่า ถ้ามากกว่าให้สลับ แล้วก็เปรียบเทียบค่าตัวถัดไปอีกเรื่อยๆจนหมดอาเรย์

2. What if two numbers equal, what will happen? 

Answer: ไม่สลับและ flag = false

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 9

4. Why we need flag variable ? 

Answer: เพื่อให้โปรแกรมรู้ว่า sort เสร็จแล้ว จึงเบรค

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: เร็วขึ้นในเคสที่สมาชิกจัดเรียงมาอยู่แล้วกับเคสที่ตัวแรกมีค่ามากที่สุดและตัวต่อๆไปจัดเรียงกันอยู่แล้ว