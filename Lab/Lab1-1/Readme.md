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
 
Answer: จาก input มีตัวเลข 4,5,2,8,9,1,2,4,3,1 กำหนดให้ flag=true เมื่อเข้ามาในลูป while กำหนดให้ flag=false จะเข้าลูป for 
โดยเริ่มที่ i=0 เท่ากับเลข 4 กับ i+1 เท่ากับเลข 5 จะไม่ได้เข้า if เพราะ 4 ไม่ได้มากกว่า 5 ตัวถัดไปเป็นเลข 5,2 จะเข้า if เพราะ 5 มากกว่า 2 
แล้วจึงทำการสลับเลข 5,2 เป็น 2,5 แล้วให้ flag=true แล้วจึงทำการวลลูปไปเลื่อยๆ จนถึง i=10 จึงออกนอกลูปแล้ววนเข้าลูป for อีกรอบทำไปเรื่อยๆ 
จนถึงตัวสุดท้ายให้ flag=false เข้ามาในลูป for แต่ไม่ได้เข้า if จึงหลุดออกจากลูป for โดยที่ค่า flag=flase แล้วจึงหลุดออกจากลูป while ด้วยจึงจบการทำงาน

2. What if two numbers equal, what will happen? 

Answer: เมื่อตัวเลขเท่ากันจะไม่ได้เช้า if แล้วจึงทำ i ตัวถัดไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (x-1)^2

4. Why we need flag variable ? 

Answer: ใช้เพื่อทำการเข้าลูป while 

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:จะทำงานได้ช้าลง เพราะต้องการเช็คทุกรอบ