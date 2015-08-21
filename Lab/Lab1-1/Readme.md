# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:a7edd79b0f42d61c79b0db5ad0aaaa586606c78f
* Without flag:ca3e8828430d45b9bfee147dc797c7e0373d7213

## Questions
1. How this code can sort number from smaller to larger
 
Answer: สลับไปที่ละตำแหน่งโดยไล่ไปเรื่อยๆว่าตำแน่งที่iมากกว่าตำแหน่งที่ i+1หรือไม่ ถ้าใช่ก็จะสลับตำแหน่งของมัน มีการบวกค่าiไปที่ละหนึ่งแล้วทำไปเรื่อยๆ

2. What if two numbers equal, what will happen? 

Answer: ไม่มีการสลับที่

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1,(n-1)^2]

4. Why we need flag variable ? 

Answer: เพื่อที่เราจะเข้าลูปได้

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: มันจะช้ากว่าเดิม