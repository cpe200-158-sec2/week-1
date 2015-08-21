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
 
Answer: เข้า loop จัดทีละตัวตั้งแต่ตัวแรกไปจนตัวสุดท้ายโดยเช็คตามเงื่อนไข ถ้าตัวข้างหน้ามากกว่าตัวข้างหลังให้ swap ไป เช็คทีละตัว ถ้ายังจัดไม่เสร็จกูจะเข้า loop while อีกรอบ  แล้วก็ทำซ้ำจนกว่าจะถูกหมดและออก loop while เมื่อจัดเรียงเสร็จ

2. What if two numbers equal, what will happen? 

Answer: ถ้าเลขที่ติดเท่ากันจะไม่เกิดอะไรขึ้นและข้ามไปทำในตัวถัดไปเลย เพราะผิดเงือนไข

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1 , (n-1)^2] n=size of inout

4. Why we need flag variable ? 

Answer: ใช้ bool flag มาเป็นตัวเช็คการวนเข้า loop เพื่อออก loop while

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ช้าลงเพราะไม่มีการเช็ค จะต้องวน loop ให้ครบจนเกินความจำเป็น