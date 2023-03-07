// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] GetArray(int m, int n, int min, int max)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max);
        }
    }
    return res;
}



void CheckArrayAverage(double[,] inArray)
{
    double average = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i < inArray.GetLength(0) && j < inArray.GetLength(1)) average += inArray[j, i];
            
        }
        Console.Write($"{average /= inArray.GetLength(0)} ");
        average = 0;
    }
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
CheckArrayAverage(array);