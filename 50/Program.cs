// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max);
        }
    }
    return res;
}

bool CheckArray(int[,] array, int row, int col)
{
    if(row > array.GetLength(0) - 1 || col > array.GetLength(1) - 1)
    {
        Console.WriteLine($"В массиве нет числа с индексом [{row}, {col}].");
    }
    else
    {
        Console.WriteLine($"Искомое число {array[row, col]}");
    }
    return true;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);

Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
CheckArray(array, row, col);
