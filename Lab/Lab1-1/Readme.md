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
 
Answer:โปรแกรมจะรับตัวเลขมา แล้วจะเปรียบเทียบตัวเลขกับตัวเลขกับหลักถัดไป ถ้าหากตัวเลขถัดไปมากกว่าจะไม่สลับที่แต่หากน้อยกว่าตวเลขถัดไปจะมาอยู่ข้างหน้าแทน ทำซ้ำไปเรื่อยๆจนกว่าจะไม่มีการสลับที่อีก ก็จะได้ตัวเลขที่เรียงจากน้อยไปมาก 

2. What if two numbers equal, what will happen? 

Answer: ไม่เกิดอะไรขึ้นเพราะไม่เข้าในเงือนไขคือตัวเลขหลักหน้าต้องมากกว่าเลขหลักหลัง

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (n-1)n จะเป็นการใช้งานมากที่สุด เมื่อ n คือจำนวนตัวเลขที่ต้องการจะเรียง   

4. Why we need flag variable ? 

Answer: เพื่อตรวจสอบว่าตัวเลขนั้นเรียงเสร็จแล้วหรือยัง หากไม่มีการสลับที่แสดงว่าตัวเลขนั้นเรียงเสร็จแล้ว 

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: