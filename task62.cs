


void FillArray(int[,] arr )
{
    {
    int val = 1;
    if (val <= 4)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr[0, i] = val;
            val ++;
        }
    }
    if (val > 4 && val <= 7)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            arr[j, 3] = val;
            val ++;
        }
    }
    if (val > 7 && val <= 10)
    {
        for (int k = 2; k != 0; k--)
        {
            arr[3, k] = val;
            val ++;
        }
    }
    if (val > 9 && val <= 12)
    {
        for (int l = 3; l != 0; l--)
        {
            arr[l, 0] = val;
            val ++;
        }
    }
    if (val > 12 && val <= 14)
    {
        for (int m = 1; m < arr.GetLength(1) - 1; m++)
        {
            arr[1, m] = val;
            val ++;
        }
    }
    if (val==15)
    {
        arr[2,2]=val;
        val++;
    }
    if (val==16)
    {
        arr[2,1]=val;
        val++;
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

//КОД ОСНОВНОЙ ПРОГРАММЫ

int[,] array = InitializateArray(4,4);

FillArray(array);

PrintArray(array);

