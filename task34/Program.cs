/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
//Console.Clear();
uint EvenNum = 0;
void main(string[] args)
{
    Random r = new Random();
    int size = 10;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = r.Next(100, 1000);
        Console.Write(arr[i] + " ");
        if ((arr[i] % 2) == 0)
        {
            EvenNum++;
        }
    }
    
}
main(args);
Console.WriteLine(" Четные: " + EvenNum);

