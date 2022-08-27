// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
void FillPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindNumber(int[,] arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                Console.WriteLine($"число {number} стоит на ({i},{j}) позиции");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine($"числа {number} нет в массиве");
}
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] array = new int[m, n];
FillPrintArray(array);
Console.Write("Введите искомое число: ");
int N = Convert.ToInt32(Console.ReadLine());
FindNumber(array, N);