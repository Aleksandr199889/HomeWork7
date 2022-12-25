// Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет

Console.Write("Введите индекс нужной строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс нужного столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

int rowCount = new Random().Next(2, 5);
int  columnCount =  new Random().Next(2, 5);
int[,] array = new int[rowCount, columnCount];

void FillArray( int [,] arr)
{
    Random random = new Random();
	for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(1, 10);   
        }
    }
}


void PrintArray( int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] +  " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
if (m > array.GetLength(0) && n > array.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    void array1( int[,] arr )
    {
        Console.Write(array [m,n]);
    }
    array1(array);
}
