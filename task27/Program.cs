/*Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void main(string[] args) //главная функция(метод)
{//начало главной функции (Main)
    Console.WriteLine("Введите число: ");//вывод на консоль числа
    int x = //объявляем (создаем) переменную типа int с именем "x"
    Convert.ToInt32(Console.ReadLine()); //Ввод через коноль строки и преобразованием в обычное число
    int y = Sum(x); //объявляем (создаем) переменную типа int с именем "у" в которую кладем результат
    Console.WriteLine(y);//вывод на консоль полученного результат
}//окончание главной функции (Main)
int Sum(int a)//объявляем (создаем) переменную типа int с именем "Sum" 
{
    int res = 0;//объявляем (создаем) переменную типа int с именем "res" присваиваем ему 0
    while (a > 0)//Пока выполняется условие а >0, выполняем дейсвия в {}
    {
        res = res + (a % 10);//присваиваем переменной результат (остаток от деления переменной "a" на 10)
        a /= 10;//присваиваем переменной "a" результат целочисленного деленния переменной "a" на 10 (a=a/10)
    }
    return res;//возвращаем значение "res"
}
main(args);//вызов метода