// Задача 3. Необязательная, дополнительная задача 
// Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов).
// В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами 
//(если палиндромов нет, то среднее арифметическое считать равным 0). Полученные средние арифметические занести в одномерный массив.

// Например, задан массив:

// 100 404 504 225
// 550 478 800 363
// 505 101 410 479

// => [505, 252.5, 0, 363 ]


int rowCount = new Random().Next(3, 5);
int  columnCount =  new Random().Next(3, 5);
int[,] array = new int[rowCount, columnCount];

void FillArray( int [,] arr)
{
    Random random = new Random();
	for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(100, 1000);   
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

void FindAverage( int[,] arr)
{   
    //int size = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        double avarage = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int e = arr[i,j] / 100;
            int c = arr[i,j] % 10;
            if( e == c )
            {
                sum += arr[i,j];
                count += 1;
            }
        }
        avarage = sum / count;
        
        Console.WriteLine(avarage + "***");
        // size += 1;
        // double [] arr1 = new double [size];
        // for (int i = 0; i < size; i++)
        //     arr1[i] = avarage;
  
        // for (int i = 0; i < size; i++)
        //     Console.Write(arr1[i] + " - ");
        // Console.WriteLine();
        // Что то странное
    }
}

FillArray(array);
PrintArray(array);
FindAverage(array);