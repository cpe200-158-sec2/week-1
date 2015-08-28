# Instruction
* Read the code, understand it, think hard how it works.
* Change the code such that it will accept a number from command line, then show the result.
* Answer the questions below

# Questions
* Why we need "if-else" in function process?

Answer: เพื่อไม่ให้ fucntion recursion ทำงานไม่รู้จบ และ เพื่อไม่ให้เกิดการผิดพลาดในการคำนวณ เพราะว่าถ้าไม่ใส่ if(i > 1) จะทำให้ค่า i ลดลงเหลือสูนย์แล้ว
ถ้าค่า i เหลือสูนย์แล้วทำงานต่อในส่วนของ result = i * process(i - 1) จะทำให้ผลที่เป็นศูนย์ เนื่องจากศูนย์คูณศูนย์ได้ศูนย์


# Resources
* https://en.wikipedia.org/wiki/Recursion_(computer_science)