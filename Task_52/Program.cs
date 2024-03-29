﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

void AveregeToCols(int[,] array, int rows)
{
    for (int j = 0; j < array.GetLength(1); j++)

    {
        double sumCols = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sumCols = sumCols + array[i, j];
        Console.WriteLine($"Среднее арифметическое по столбцу  {j} равно {Math.Round(sumCols / rows, 2)}    ");
    }
    System.Console.WriteLine();
 

}



Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
AveregeToCols(array, rows);
System.Console.WriteLine();