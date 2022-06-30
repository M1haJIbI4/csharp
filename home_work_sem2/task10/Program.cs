/*
Задача 10. Программа, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
*/

Console.Write("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Second_Digit = 0;
double Buffer = Num;
while (Buffer > 1)
   {
    Buffer = Buffer / 10;
    Second_Digit++;
   }
if (Second_Digit == 3)
   {
    string stringNumber = Convert.ToString(Num);
    Console.WriteLine("вторая цифра этого числа: "+stringNumber[1]);
   }
else
   {
    Console.WriteLine("Аяяяй! "+ Num + " нетрёхзначное число!" );
   }