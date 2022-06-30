/* Задача 21. Напишите программу, которая принимает
 на вход координаты двух точек и находит 
 расстояние между ними в 3D пространстве.
*/

int     x1 = Coordinate("x", "A"), y1 = Coordinate("y", "A"), z1 = Coordinate("z", "A"),
        x2 = Coordinate("x", "B"), y2 = Coordinate("y", "B"), z2 = Coordinate("z", "B");
int Coordinate(string NameCoor, string pointName)
{
    Console.Write($"Введите координату {NameCoor} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
                {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");