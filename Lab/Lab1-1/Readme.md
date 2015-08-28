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
 
Answer: ใช้เงื่อนไขในการสลับค่าที่ป้อนเข้าไป โดยจะวนเช็คค่าทีละคู่ไล่ตั้งแต่ค่าแรกไปจนค่าสุดท้าย แล้ววนเช็คต่อๆไปตั้งแต่ค่าแรกอีกครั้ง จนกว่าค่าทั้งหมดจะเรียงจากน้อยไปมาก จึงหลุดจาก loop และจบการทำงาน

2. What if two numbers equal, what will happen? 

Answer: ไม่เข้าเงื่อนไขจึงไม่ทำการสลับค่าเพื่อเรียงจัดลำดับ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (x-1)*(x-1)

4. Why we need flag variable ? 

Answer: เพื่อบ่งบอกถึงค่าความจริง เป็นข้อกำหนดในการจบการทำงานจาก loop หรือหลุดออกจาก loop

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: โค้ดจะ run ช้าลง เพราะหากทำการเปลี่ยน จาก while(flag) เป็นการใช้ for จะทำให้โค้ดใช้เวลาในการวน loop มากกว่า จึงช้ากว่า