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
 
Answer: โปรแกรมจะวนเช็คเท่ากับจำนวนตัวเลขใน input โดยจะเช็คว่าค่าของตัวเลขในตำแหน่งที่ i และ i+1 มีค่ามากกว่า หรือน้อยกว่า ถ้าค่าของตำแหน่งที่ i มีค่ามากกว่าตำแหน่งที่ i+1 ก็สลับค่าของ ตำแหน่งที่ i และ i+1 โดยสร้างตัวแปรอีกตัวนึงมาช่วยในการสลับค่า

2. What if two numbers equal, what will happen? 

Answer: ถ้าตัวเลขสองตัวมีค่าเท่ากันโปรแกรมก็จะไม่ทำอะไร แล้วก็เช็คตัวถัดไปต่อ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (x-1)*(x-1)

4. Why we need flag variable ? 

Answer: ใช้ตัวแปล flag ในการออกลูป while โดยลูป while จะทำงานก็ต่อเมื่อ flag มีค่าเท่ากับ true

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: การทำงานของโค้ดจะช้าลง ถ้าหากเราเอาตัวแปร flag ออกจะต้องเขียนฟังก์ชั่นโดยใช้ for ซึ่งจะใช้เวลานานกว่า while