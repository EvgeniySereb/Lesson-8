

int GetNumberFromConsole(string text )
{
    
    
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    
}

int GetRandomValue()
{
    return new Random().Next(1 , 11);
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

void MultiMatrix( int [,] arr , int [,]arr2 , int[,] result , int m , int n , int x , int y)
{
    if (n != x)
    throw new Exception("Умножение невозможно количество столбцов первого массива не равно количеству строк второго");
    
    for(int i = 0; i< m; i++)
    {
        for (int j = 0;j < y; j++ )
        {
            result[i , j] = 0;
            for(int k = 0; k < n; k++)
            {
                result[i , j] += arr[i , k ] * arr2[k , j];

            }
        }

    }
}
//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите количество строк  1 массива " );
int n = GetNumberFromConsole("Введите количество столбцов  1 массива "  );
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
int x = GetNumberFromConsole(" Введите количество строк 2 массива"  );
int y = GetNumberFromConsole(" Введите количество столбцов 2 массива");

int [,] array2 = InitializateArray(x , y);
FillArray(array2);
PrintArray(array2);

Console.WriteLine();
int[,] arrayResult = new int [m , y];
MultiMatrix(array ,array2 , arrayResult, m , n , x , y);
PrintArray(arrayResult);
