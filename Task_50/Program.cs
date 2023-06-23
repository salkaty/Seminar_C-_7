// // Задача 50. Напишите программу, которая на вход принимает значение элемента
//  в двумерном массиве, и возвращает позицию этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);

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

void FindNumber(int number, int[,]array)
{
    int count=0;
    
for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        
        if (array[i, j]==number) 
            {
                count++;
              System.Console.WriteLine($"Такое число находится на {i} строчке и {j} столбце");
              break;
            }

  if(count==0)
        {
            System.Console.WriteLine($"Такое число {number} в массиве не найдено");
        }
}

Console.Clear();

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
FindNumber(number,array);