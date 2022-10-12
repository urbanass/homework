/* Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 без math.pow*/

void main()
{
    Console.WriteLine("Введите число: ");
    int x =
    Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень: ");
    int y =
    Convert.ToInt32(Console.ReadLine());
    int z = MyPow(x, y);
    Console.WriteLine(z);
}
int MyPow(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}



main();