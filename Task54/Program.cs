int row = new Random().Next(2, 6);
int column = new Random().Next(2, 6);
int[,] array = new int[row, column]; 


CreateArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

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

void SortArray(int[,] array)
{
    int temp;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }
            }
        }
    }
}