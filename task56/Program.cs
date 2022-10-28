// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr = new int[6, 2];
Random random = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("--------------");
for (int j = 0; j < arr.GetLength(0); j++)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[j, i];
    }
    Console.Write(sum + "; ");
}
void SumElements(int[,] arr)
{
    int minRow = 0;
    int minSum = 0;
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minRow += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sumRow += arr[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSum = i + 1;
        }
        sumRow = 0;
    }
    Console.Write("--------------");
    Console.Write($"{minSum} строка c наименьшей суммой");
}
SumElements(arr);