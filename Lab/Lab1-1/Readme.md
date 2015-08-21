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
 
Answer: ทำงานโดยจะเช็คค่าข้อมูลเป็นคู่ๆ โดยให้ตัวเลขที่มีค่ามากกว่าจะถูกสลับไปทางด้านหน้า

2. What if two numbers equal, what will happen? 

Answer: เมื่อเช็คเงื่อนไขที่ฟังชั่น if ก็จะข้ามส่วนนี้ไปเพราะไม่ตรงเงื่อนไขใน if

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [x-1,(x-1)^2]

4. Why we need flag variable ? 

Answer: เพื่อให้เข้าวูบ while ในตอนแรก และ เพื่อทำให้สามารถออกลูบ while ได้เมื่อเราเรียงค่าได้ถูกต้องแล้ว

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: เมื่อนำค่า flag ออก ต้องใช้ฟั่งชั่น for แทนจะทำให้โปรแกรมทำงานช้าลง