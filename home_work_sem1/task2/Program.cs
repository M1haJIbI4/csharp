Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
        Console.WriteLine("А вот и ответ: ");
        Console.Write("{a} = max, {b} = min");
}

else  
{
        Console.WriteLine("А вот и ответ: ");
        Console.Write("b = max, a = min");
}