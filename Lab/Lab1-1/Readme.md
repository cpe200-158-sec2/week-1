# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:
flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เช็คตัวเลขที่ละตัวโดยนำตัวที่ 1 ไปเช็คกับตัวที่ 2 ว่ามีค่ามากกว่าไหม ถ้ามีค่ามากกว่า ให้สลับที่กัน ถ้าสลัยที่เสร็จเเล้วหรือมีค่าน้อยกว่า โปรเเกรมจะนำตัว2 มา เช็คกับ3  ทำวนไปจนครบทุกตัว ตามลำดับ 
หากโปรเเกรมมีการสลับที่ โปรเเกรมจะทำซ้ำอีกรอบ 
หากโปรเเกรมไม่มีการสลับที่ โปรเเกรมจะหยุดลูบเเละปริ้นค่าตัวเลขออกมา

2. What if two numbers equal, what will happen? 

Answer ผลลัพออกมา ตัวเลขจะอยู่ติดกัน 

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (x-1)x เมื่อ xคือจำนวนตัวเลข

4. Why we need flag variable ? 

Answer: เพื่อที่จะเช็คว่า มีการสลับตัวเลขเกิดขึ้นไหม ถ้าไม่มีเเสดงว่าเรียงตัวเลขถูกต้องเเล้ว ถ้ามีอาจจะยังมีตัวเลขที่ยังไม่ได้เรียงอยู่  

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: