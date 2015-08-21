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
 
Answer: โปรแกรมจะเริ่มเปรียบเทียบจากอาเรย์ช่อง 0 กับอาเรย์ช่อง 1 ถ้าช่อง 0 มีค่ามากกว่าช่อง 1 จะทำการสลับตำแหน่งกัน
		ต่อไปจะเปรียบเทียบช่อง 1 กับช่อง 2 ถ้าช่อง 1 มีค่ามากกว่าช่อง 2 จะทำการสลับตำแหน่งกัน
		โปรแกรมจะอ่านไปเรื่อย ๆ จนเปรียบเทียบระหว่างช่องสุดท้ายกับรองสุดท้าย จะได้ตัวเลขที่มากที่สุดอยู่ที่ช่องสุดท้าย
		เมื่อครบรอบแรก ลูป While จะเช็คว่าในรอบสุดท้ายของลูป For นั้น โปรแกรมมีการสลับตำแหน่งอยู่หรือไม่
		หากมีการสลับตำแหน่งอยู่ แสดงว่าการเรียงลำดับในอาเรย์ยังไม่เรียงจาก น้อยไปมาก ทุกตำแหน่ง
		โปรแกรมจะวนมาเข้าลูป For อีก จนกระทั่งค่า Flag ที่ออกมาจากลูป For มีค่าเป็น False

2. What if two numbers equal, what will happen? 

Answer: ไม่มีการสลับตำแหน่งกัน ผลสุดท้ายเลขที่เท่ากันจะอยู่ตำแหน่งติดกัน

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n(n-1) เมื่อ n คือจำนวนตัวเลขในอาเรย์

4. Why we need flag variable ? 

Answer: เช็คว่ามีการเรียงลำดับจากน้อยไปมากทุกตำแหน่งแล้วหรือยัง หากมีการสลับตำแหน่งกันค่า Flag จะเป็น True คือยังเรียงไม่เสร็จ
		หากค่า Flag เป็น False คือไม่มีการสลับตำแหน่ง แสดงว่าเรียงลำกับทุกตำแหน่งครบแล้ว ออกโปรแกรม

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: 