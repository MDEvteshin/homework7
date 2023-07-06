// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i,j] = new Random().Next(minValue, maxValue + 1);   
        }   
    }
    return array;
}

void Print2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength (0); i++) 
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }   
        System.Console.WriteLine(); 
    }
    System.Console.WriteLine();
}



System.Console.WriteLine("Input number of row");
int rows = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Input number of column");
int columns = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element");
int maxValue = Convert.ToInt32 (Console.ReadLine ());

int [,] myArray = (Create2DArray (rows, columns, minValue, maxValue)); 
Print2DArray(myArray);

Print2DArray(minni(myArray));