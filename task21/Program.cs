/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int ax, ay, az;
int bx, by, bz;
double rDoub = 0;

Console.WriteLine("Введите координаты: ");
Console.WriteLine("ax: ");
ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ay: ");
ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("az: ");
az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("bx: ");
bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("by: ");
by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("bz: ");
bz = Convert.ToInt32(Console.ReadLine());
//√((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2
rDoub = Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2); //возведения числа в степень.
rDoub = Math.Sqrt(rDoub); //функция которая извлекает квадратный корень
rDoub = Math.Round(rDoub, 3);// округление до 4 знача после ","
Console.WriteLine(rDoub);