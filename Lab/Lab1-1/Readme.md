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
 
Answer: โปรแกรมจะทำการสลับเลขเทียบกับตัวต่อไป โดยจะทำต่อไปเรื่อยๆ 

2. What if two numbers equal, what will happen? 

Answer: จะไม่เกิดการสลับที่ 

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: อย่างน้อย (n-1) รอบ
		อย่างมาก (n-1)^2 รอบ

4. Why we need flag variable ? 

Answer: เพื่อนตรวจสอบความถูกต้องขอโปรแกรมว่าเรียงตัวเลขถูกต้องหรือไม่

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: โปรแกรมจะรันเร็วขึ้นแต่สามารถเกิดข้อผิดพลาดได้ (อาจได้ผลลัพท์ที่ไม่ถูกต้อง)