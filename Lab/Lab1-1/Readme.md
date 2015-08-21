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
 
Answer: โปรเเกรมจะทำการวนลูป โดยมีการกำหนดเงื่อนไขเอาไว้ว่าถ้าตัวเลขลำดับที่น้อยกว่านั้นมีค่ามากกว่าลำดับถัดไปจะทำการสลับตัวหลังมาไว้ด้านหน้า โดยในลูปเเต่ละรอบจะจัดตัวเลขไปเรื่อยๆจนกว่าเลขทั้งหมดจะเรียงกัน

2. What if two numbers equal, what will happen? 

Answer: จะไม่มีการเคลื่อนย้ายหรือสลับตัวเลขใดๆ เพราะไม่ได้ถูกกำหนดอยู่ในเงื่อนไขที่โปรเเกรมต้องทำ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: O(n*log n)

4. Why we need flag variable ? 

Answer: เพื่อให้เป็นตัวกำหนดว่ากรณีเเต่ละกรณีนั้นเข้าเงื่อนไข true หรือ false เพื่อให้เข้าลูปเเละทำงานในรอบต่อไป ถ้าไม่มีการสลับก็จะเกิดการตัดโปรเเกรมออก

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: