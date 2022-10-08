/*Напишите метод, который принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
    void Main(int day)
{
    if (day >= 1 && day <= 7)
        {
        if (day == 6 | day == 7) Console.WriteLine("Сегодня выходной");
        else Console.WriteLine("Сегодня рабочий день");
        }
    else Console.WriteLine("Упс,прочитай условие");
}

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
Main(day);
