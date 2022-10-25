/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] arg1 = { { 2, 4 },
                { 3, 4 } };

int[,] arg2 = { { 3, 2 },
                { 3, 3 } };

int[,] m = CreateMatrix(arg1, arg2);
// c11 = a11 · b11 + a12 · b21 = 2 · 3 + 4 · 3 = 6 + 12 = 18
// c12 = a11 · b12 + a12 · b22 = 2 · 2 + 4 · 3 = 4 + 12 = 16
// c21 = a21 · b11 + a22 · b21 = 3 · 3 + 4 · 3 = 9 + 12 = 21
// c22 = a21 · b12 + a22 · b22 = 3 · 2 + 4 · 3 = 6 + 12 = 18
int[,] CreateMatrix(int[,] arg1, int[,] arg2)
{
    int[,] m = new int[arg1.GetLength(0), arg2.GetLength(1)];

    for (int i = 0; i < arg1.GetLength(0); ++i)
        for (int j = 0; j < arg2.GetLength(0); ++j)
            for (int k = 0; k < arg2.GetLength(1); ++k)
                m[i, k] += arg1[i, j] * arg2[j, k];
    return m;
}
void main()
{
    for (int i = 0; i < arg1.GetLength(0); ++i)
    {
        Console.Write("|");
        for (int j = 0; j < arg2.GetLength(1); ++j)
        {
            Console.Write(m[i, j] + "|");
        }
        Console.WriteLine();
    }
}
main();
