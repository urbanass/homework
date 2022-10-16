/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();
void main(string[] args)
{
    Random r = new Random();
    int size = 4;
    int sum = 0;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = r.Next(-20, 20);
        Console.Write(arr[i] + " ");
    }
    for (int i = 0; i < size; i += 2)
    {
        sum += arr[i+1];
    }
    Console.WriteLine(" Сумма Нечетных поиций = "+ sum);
}
main(args);

