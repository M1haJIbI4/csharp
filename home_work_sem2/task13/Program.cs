/* Задача 13. Программа, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/


Console.Write("Введите число: "); 
int randomNumber = Convert.ToInt32(Console.ReadLine()); 
string randomNumberText = Convert.ToString(randomNumber); 
if (randomNumberText.Length > 2)
        {
                 Console.WriteLine("третья цифра введенного числа: "+randomNumberText[2]);
                  } 
else 
{ Console.WriteLine("третьей цифры нет"); }
