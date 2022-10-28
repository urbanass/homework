// Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы,
//  так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6

// Одно из решений :
// Группа 1: 1 
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 7 16 24 36 40 
// Группа 6: 5 32 48
// Ещё одно решение:
// Группа 1: 1 
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 16 24 36 40 
// Группа 6: 32 48
// Задача: найти M при заданном N и получить одно из разбиений на группы
// N ≤ 10²⁰

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] tempArray = CreateArray(n);
CreateRows(tempArray);

void CreateRows(int[] Array)
{
    int[] array = new int[Array.Length];
    int group = 1;
    int count = 0;
    int Number = 0;
    int Number2 = 0;
    int next = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        System.Array.Clear(array);
        count = 0;
        if (Array[i] != 0)
        {
            array[count] = Array[i];
            Number2 = Array[i];

            for (int j = i; j < Array.Length; j++)
            {
                if (Array[j] % Number2 != 0 || Array[j] / Number2 == 1)
                {
                    next = 0;
                    Number = Array[j];
                    for (int k = 0; k < count; k++)
                    {
                        if (Number % array[k] == 0) next++;
                    }
                    if (next == 0)
                    {
                        array[count] = Array[j];
                        count++;
                        Array[j] = 0;
                    }
                }
            }
            Console.WriteLine($"Группа {group++}: {PrintIntArray(array)}");
        }
    }
}

int[] CreateArray(int n)
{
    int[] temp = new int[n];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = i + 1;
    }
    return temp;
}
string PrintIntArray(int[] array)
{
    string result = string.Empty;//объявляем строку присваиваем пустое значение.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) result += $"{array[i],3} ";
    }
    return result;
}