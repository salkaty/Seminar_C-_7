﻿// // Задача 50. Напишите программу, которая на вход принимает значение элемента
//  в двумерном массиве, и возвращает позицию этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
            
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

 void  FindIndex(int[,] array, int count, int index)
 {
   
if (index>count)
{
    System.Console.WriteLine("Такого элемента массива не существует"); 
}
}


Console.Clear();

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер элемента массива"); 
int index =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
int count = rows*cols;
PrintArray(array);
FindIndex(array,count,index);