

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
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
    Console.WriteLine();
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

void GetMinSum(int [,] arr , int [] sumArr)
{
    int sum = 0;
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];

            if (j == (arr.GetLength(1) - 1))
            {
                sumArr[i] = sum;
              sum = 0;
              
            }
            
         

        }
          Console.Write(sumArr[i] + " ");
          
    }
      Console.WriteLine();
}  
void MinLine(int [] sumArr)
{
    
    int min = sumArr[0];
     for(int i = 1; i < sumArr.Length; i++)
     {
         if( min > sumArr[i] )
         {
            min = sumArr[i];
            
         }   
         if (min == sumArr[i])
         {
         min = i;
         }
     }
     
     Console.WriteLine($"Строка с наименьшим значением :{min +1 }");
}
  
//КОД ОСНОВНОЙ ПРОГРАММЫ

int[,] array = InitializateArray(5,5);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
int []arraySum = new int[5];
PrintArray(array);
GetMinSum(array , arraySum);
MinLine(arraySum);
