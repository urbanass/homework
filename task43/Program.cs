﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void NewMethod(double k1, double b1, double k2, double b2, out double x, out double y)
{
    x = -(b1 - b2) / (k1 - k2);
    y = k1 * x + b1;
}

//значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x, y;

NewMethod(k1, b1, k2, b2, out x, out y);

Console.WriteLine($"Пересечение в точке: ({x};{y})");

