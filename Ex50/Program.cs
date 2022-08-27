// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindNumber(int[,] arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
            if (arr[i, j] == number) count++;
        }
        Console.WriteLine();
    }
    if (count == 0) Console.WriteLine($"нет числа {number} в массиве");
    else Console.WriteLine($"число {number} есть в массиве {count} раз");
}

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] array = new int[m, n];
Console.Write("Введите искомое число: ");
int N = Convert.ToInt32(Console.ReadLine());
FindNumber(array, N);

