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
 
Answer: ตรวจสอบเลขที่ละคู่ ถ้าตัวเเรกมากกว่าตัวถัดไป จะทำการสลับที่กัน แล้วตรวจสอบเลขคู่ถัดไปเรื่อยๆ วนลูปจนเรียงเลขเสร็จ

2. What if two numbers equal, what will happen? 

Answer: ข้ามเลขคู่นั้นไป ไม่ทำการสลับ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n*(n-1)/2

4. Why we need flag variable ? 

Answer: เพื่อทำการวนลูปเมื่อค่า flag เป็นจริง และ ออกจากลูปเมื่อ flag เป็นเท็จ

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: เมื่อนำค่า flag ออกจะทำให้ลูป for ทำงานมากขึ้น โปรแกรมจะทำงานช้าลง