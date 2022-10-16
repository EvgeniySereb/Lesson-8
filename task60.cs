
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0 ; k <arr.GetLength(2); k++)
            {
            arr[i , j , k] = GetRandomValue(minValue,maxValue);
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k =0; k <arr.GetLength(2); k++)
            {
             Console.Write($"{arr[i, j, k]} \b ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] InitializateArray(int m, int n , int s)
{
    return new int[m , n , s];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива количество строк");
int n = GetNumberFromConsole("Введите размерность массива количество столбцов");
int s = GetNumberFromConsole("Введите глубину массива");
int[,,] array = InitializateArray(m,n , s);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);

PrintArray(array);

