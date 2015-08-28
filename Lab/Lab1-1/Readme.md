# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 8647a1b59afb5b33c02a63c431b871aab57301b8
* Without flag: 8647a1b59afb5b33c02a63c431b871aab57301b8 (same as above)

## Questions
1. How this code can sort number from smaller to larger
 
Answer: โค้ดบรรทัดที่24-30จะทำการสลับเอาเลขที่ทีค่ามากกว่าไว้ด้านขวา โดยโค้ดบรรทัดที่22จะทำให้เกิดลูปทำให้เลขทุกตัวเข้าโค้ดบรรทัดที่24 โดยโปรแกรมนี้จะทำงานไปเรื่อยๆจนกว่าflagจะมีค่าเป็นfalse (flagจะเป็นfalseก็ต่อเมื่อไม่เกิดการสลับตำแหน่งตัวเลขแล้ว=เรียงลำดับถูกต้องแล้ว)จากนั้นก็แสดงค่าที่เรียงแล้วออกมา

2. What if two numbers equal, what will happen? 

Answer: ไม่เกิดการสลับตำแหน่ง

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: ให้x เป็นจำนวนเลขที่ใส่ line24 จะทำงานทั้งหมด (x-1)รอบเป็นอย่างต่ำในกรณีที่เลขเรียงกันแต่แรก และอย่างมากที่สุด x(x-1)รอบถ้าเลขที่ใส่เรียงจากมากไปน้อย

4. Why we need flag variable ? 

Answer: ทำให้ลูปจบลงเมื่อตัวเลขเรียงกันเสร็จแล้ว

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ถ้าตัวเลขเรียงกันจากน้อยไปมากอยู่แล้ว หรือสลับตัวเลขแค่ไม่กี่ตัว ลูปจะจบไว ทำให้codeไวขึ้น แต่ถ้าตัวเลขเรียงจากมากไปน้อย codeจะต้องใช้ทุกรอบ ทำให้ช้าลง 
