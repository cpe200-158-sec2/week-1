# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:

				if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }

* Without flag:

		for (int j = 0; j <= input.Length - 1; j++)
            {
                
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (input[j] > input[i])
                    {
                        int temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                        
                    }
                
                }
            }

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เรียงลำดับตั้งแต่ตัวแรก หากตัวแรกมากกว่าตัวถัดไปจะสลับเอาตัวที่น้อยกว่ามาไว้ข้างหน้า แล้วเช็คตัวถัดไป ถ้ามากกว่าก็จะข้ามไปดูในลำดับถัดไป ถ้าน้อยกว่าก็จะทำการสลับอีก จะครบ
		แล้ววนกลับมาเริ่มต้นเช็คใหม่อีกครั้ง จนกว่าเลขจะเรียงลำดับจากน้อยไปมากถูก
2. What if two numbers equal, what will happen? 

Answer: ตัวเลขที่เท่ากัน จะถูกเรียงติดกัน

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n(n-1)
 
4. Why we need flag variable ? 

Answer: เพื่อเป็นการเช็คว่าตัวเลขเรียกได้อย่างถูกต้องแล้วหรือยัง

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ช้าลง เพราะทำการ วน loop มากกว่าเดิม