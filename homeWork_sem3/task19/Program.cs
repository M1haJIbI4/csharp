/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
*/

Console.Write("Введите пять цифр или символов: ");
string? num = Console.ReadLine();

void CheckingNumber(string num)
{
  if (num[0] == num[4] & num[1] == num[3])
  {
    Console.WriteLine($"{num} - палиндром");
  }
  else Console.WriteLine($"{num} - не палиндром");
}

if (num!.Length == 5)
{
  CheckingNumber(num);
}
else Console.WriteLine($"Введенный текст/число {num} не пятизначное, введите пятизначное число/текст");