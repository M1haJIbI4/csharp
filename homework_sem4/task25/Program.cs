/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/
int taskExp (int numA, int numB)
{
  int res = 1;
  for (int i=1; i <= numB; i++)
  {
    res = res * numA;
  }
    // int res = Math.Pow(numA, numB);
    return res;
}

  Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());
  if (numA > 0 && numB > 0 )
    {
     int taskexp = taskExp(numA, numB);
     Console.WriteLine("Ответ: " + taskexp);
    }
  else
    {
     Console.WriteLine($"Внимание! Числа {numA} и/или {numB} не является натуральным, введите число больше 0");
     return;
    }
  