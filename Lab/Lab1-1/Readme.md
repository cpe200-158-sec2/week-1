# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 432063415528baa3ae233d77fcdd23234c5bb904
* Without flag: ceb84d31e01fd75ba73470df1641603b27210b6b

## Questions
1. How this code can sort number from smaller to larger
 
Answer: โค้ดนี้ทำงานโดยมี array input เป็นข้อมูล ในกระบวนการทำงานจะมีตัวแปรประเภท boolean ที่ชื่อว่า flag คอยเช็คว่า ข้อมูลทั้งหมดนั้น เรียงถูกต้องแล้วหรือยัง โดยจะอยู่ในรูป while(flag) ถ้าค่า flag เป็น false ก็ถือว่าจบกระบวนการ ในกระบวนการจะให้ค่า flag เป็น false ก่อน แล้วใน for loop ที่จะวนตามจำนวน input จะมี if คอยเช็คว่า input ตัวนั้นๆมีค่ามากกว่าตัวถัดไปหรือไม่ ถ้ามากกว่า จะทำการสลับค่าให้ค่าน้อยมาก่อน แล้วจะไปคิดตัวถัดไปต่อ จนครบตามจำนวน input และหลุด for loop ถ้ามีการจัดเรียงใน loop นั้น จะทำให้ flag มีค่าเป็น true แล้วจะทำการจัดเรียงอีกครั้งไปเรื่อยๆ จนกว่าค่าทั้งหมดจะเรียงอย่างถูกต้อง และจะไม่เข้า if ทำให้ไม่มีการเปลี่ยนค่า flag เป็น true ทำให้หลุด while loop หลังจากหลุดแล้ว ก็จะแสดงค่าออกมาทาง console

2. What if two numbers equal, what will happen? 

Answer: จะไม่เข้ากระบวนการ if แล้วก็จะข้ามไปคิดตัวถัดไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [x , x^2] , x = size of input

4. Why we need flag variable ? 

Answer: เพื่อเช็คความถูกต้องว่า input นั้น เรียงเสร็จแล้วหรือยัง

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: โค้ดทำงานช้าลง เพราะทำงานจนครบตามจำนวนที่กำหนดจะทำหลายครั้งกว่าใช้ flag เช็คความถูกต้อง