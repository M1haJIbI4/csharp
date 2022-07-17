/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.WriteLine ("Введите числа через запятую,без пробелов: ");
string num = Console.ReadLine();
string [] newNum = new string [num.Length];
int M = 0;
for (int i = 0; i < newNum.Length; i++)
{
  if (num[i] == ',')
  {
    M++;
  }
  else
  {
    newNum[M] = newNum[M] + $"{num[i]}";
  }
}
M++;
int [] resultNum = new int[M];
PrintArray (resultNum, newNum);
int sum = 0;
for (int i = 0; i < M; i++)
{
  if (resultNum[i] > 0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше нуля: " + sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i] + " ");
  }
Console.WriteLine();
}