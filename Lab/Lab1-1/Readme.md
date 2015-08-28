﻿# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 856ddea8344afee089baba3b44190087027c0162
* without flag: 7a65b5b658f7a632b6aaae841869ab9160ff4461

## Questions
1. How this code can sort number from smaller to larger
 
Answer: โดยการเปรียบเทียบ เลขสองตัว เลขที่น้อยกว่าจะถูกสลับมาด้านหน้า

2. What if two numbers equal, what will happen? 

Answer: ก็ไม่เกิดการเปรียบเทียบกัน ไปต่อที่ i++ เลย

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [i-1,(i-1)^2]

4. Why we need flag variable ? 

Answer: เป็นตัวกำหนดเงื่อนไขในการเข้า loop while ถ้าเลขทั้งหมดเรียงเสร็จหมดแล้วจะออกจากการวนลูปทันที

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: เอา flag ออกแล้วใช้ loop for วนแทน จะทำให้โปรแกรมต้องประมวลผลช้า