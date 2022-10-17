// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//Console.Clear();
Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
RandNum(numbers);
Console.Write("массив: ");
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
void RandNum(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ; ");
    }
    Console.WriteLine();
}
PrintArray(numbers);
Console.WriteLine($"Max = {max}, Min = {min}");
Console.WriteLine($"Разница между max и min числом = {max - min}");