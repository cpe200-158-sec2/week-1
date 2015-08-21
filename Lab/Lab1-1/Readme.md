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
 
Answer: เปรียบเทียบ arrey ช่องที่ i กับช่อง i+1 เป็นคู่ ๆ ถ้าช่องที่ i มากกว่าก็จะสลับกัน ทำจนว่าจะเรียงครบทุกตัว

2. What if two numbers equal, what will happen? 

Answer: ก็จะข้าม โค้ดในif ไป แล้วนับ for ต่อ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (x-1)*(x-1)

4. Why we need flag variable ? 

Answer: เพื่อที่จะทำให้โปรแกรมหยุดการจัดเรียง และอาจจะเสร็จเร็วขึ้นในข้อมูลบางกรณี

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ถ้าเราใช้ for แทน while(flag) จะทำให้โค้ดทำงานได้ช้ากว่าในกรณีที่ข้อมูลสลับเพียงไม่กี่ครั้งก็จะได้ผลลัพธ์ที่ต้องการ 
		ซึ่งแบบนี้ ใช้flag จะทำให้โปรแกรมทำงานเร็วกว่า 