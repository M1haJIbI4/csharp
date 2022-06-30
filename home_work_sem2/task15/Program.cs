/*Задача 15: Напишите программу, 
которая принимает на вход цифру,
 обозначающую день недели, и проверяет, 
 является ли этот день выходным. */

Console.Write("Проверим, является ли день выходным? Введите цифру: "); 
int NumDay = Convert.ToInt32(Console.ReadLine());

void Check_Day_week (int NumDay) 
{
         if (NumDay == 6 || NumDay == 7) 
         { 
                Console.WriteLine("да, это выходной!"); 
                } 
                else if (NumDay < 1 || NumDay > 7) 
                { 
                        Console.WriteLine("Это не день недели, введите от 1 до 7"); 
                        } 
                        else Console.WriteLine($"Вы ввели будний день. {NumDay} - не выходной день"); 
                        }

Check_Day_week(NumDay);