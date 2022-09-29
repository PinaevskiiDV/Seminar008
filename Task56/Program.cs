int row = new Random().Next(2, 6);
int column = new Random().Next(2, 6);
int[,] array = new int[row, column]; 
int[] arr = new int[row];
int min = 0;

CreateArray(array);
PrintArray(array);
Console.WriteLine();
SumElementsString(array);
FindEqualString(arr);

Console.WriteLine($"{FindMinSumString(arr) + 1} строка");

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10); 
        }
    }
}


void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine(); 
    }
}

void SumElementsString(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] += array[i,j]; 
        }
    }
}

void FindEqualString(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i != FindMinSumString(arr) && arr[i] == arr[FindMinSumString(arr)])
        {
            Console.Write($"Сумма элементов разных строк равна: {i + 1} и ");

        }
    }
}

int FindMinSumString(int[] arr)
{
    min = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[min] > arr[i + 1])
        {
            min = i + 1;
        }
    }
    return min;
}