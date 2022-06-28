Console.Write("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Third_Digit=0;
double Buffer = Num;
while (Buffer>1)
   {
    Buffer=Buffer/10;
    Third_Digit++;
   }
if (Third_Digit == 3)
   {
    int Result = Num%10;
    Console.WriteLine("Последняя цифра числа " + Num + " - " +Result);
   }
else
   {
    Console.WriteLine("Аяяяй! "+ Num + " нетрёхзначное число!" );
   }