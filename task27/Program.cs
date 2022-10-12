/*Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void main(string[] args)
{
    Console.WriteLine("Введите число: ");
    int x =
    Convert.ToInt32(Console.ReadLine());
    int y = Sum(x);
    Console.WriteLine(y);
}
int Sum(int a)
{
    int res = 0;
    while (a > 0)
    {
        res = res + (a % 10);
        a /= 10;
    }
    return res;
}
main(args);