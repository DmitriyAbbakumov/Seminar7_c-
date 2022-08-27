// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < num.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < num.GetLength(0); j++)
    {
        sum = sum + num[j, i];
    }
    Console.Write($"{Math.Round(sum/m, 2)}; ");
}
