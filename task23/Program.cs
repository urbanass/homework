/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


Console.Write("До какого числа вы хотите вычислить куб?: "); // предложение пользователю ввести число
int num = Convert.ToInt32(Console.ReadLine());//в переменную типа int помещаем число (конвертируемое из строки в число)
for (int i = 0; i <= num; i++) //цикл выполняется с началом цикла 0 и пока выполняются условия увеличивать значение на +1
Console.Write($"{i*i*i}, ");//вывод результата на консоль



