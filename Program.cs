// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++) 
//     {
//         System.Console.Write("[ ");
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }   
//         System.Console.Write("]"); 
//         System.Console.WriteLine("");
//     }
// }

// Console.WriteLine("Input number of rows");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];

// FillArrayRandomNumbers(numbers);
// Print2DArray(numbers);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


