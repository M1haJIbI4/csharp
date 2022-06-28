Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
        Console.WriteLine("А вот и ответ: ");
        Console.Write($"{a} (a) - максимальное значение, {b} (b) - минимальное значение");
}

else  
{
        Console.WriteLine("А вот и ответ: ");
        Console.Write($"{b} (b) - максимальное значение, {a} (a) - минимальное значение");
}