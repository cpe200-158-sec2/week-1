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
 
Answer: โปรแกรมจะรับค่าตัวที่ i แล้วจะเปรียบเทียบกับตัวที่ i+1 ว่ามีค่ามากกว่าไหม ถ้ามากกว่าจะสลับตำแหน่งกัน
 

2. What if two numbers equal, what will happen? 

Answer: โปรแกรมจะข้ามตัวนั้นไป (ตำแหน่งจะไม่สลับ)

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 และจะมีค่ามากที่สุดเมื่อ n(n-1)

4. Why we need flag variable ? 

Answer: เพื่อกำหนดช่องทางการทำงานของโปรแกรม ถ้าข้อมูลเป็นจริงจะทำคำสั่งอีกแบบ ถ้าไม่เป็นจริงจะทำอีกแบบ


5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:slower because program will run a lot of loop.