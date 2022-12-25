// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

// m = 3, n = 4.

// 0.5 7.96 -2.78 -0.2

// 1.7 -3.3 8.574 -9.9

// 8.5 7.87 -7.1 9.15

Console.WriteLine("Введите число строк m" );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n" );
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[m, n];
void PrintArray(double [,] arr)
{
    for ( int i = 0; i < m; i++)
    {
        for ( int j = 0; j < n; j++)
        {
            Console.Write(" " + Math.Round(array[i,j], 2));
        }
    Console.WriteLine();
    }
}


void FillArray (double[,] arr)
{
    Random rnd = new Random();
    for ( int i = 0; i < m; i++)
    {
        for ( int j = 0; j < n; j++)
        {
            arr [i,j] = rnd.NextDouble();
        }
    }
}

FillArray(array);
PrintArray(array);
