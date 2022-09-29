
Console.Write("Enter number of rows for first matrix: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter  number of columns for first matrix: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows1, columns1];

Console.WriteLine("Enter number of rows for second matrix: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter  number of columns for second matrix: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = new int[rows2, columns2];

FillArrayRandomNumbers(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArrayRandomNumbers(matrix2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Резальтат умножения матриц: ");
int[,] multiplicationMatrix = MatrixMultiplication(matrix1, matrix2);
PrintArray(multiplicationMatrix);
// int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matr2)
// {
//     if (matrix1.GetLength(1) = matr2.GetLength(0))
//     {
//         int[,] result = new int[matrix1.GetLength(0), matr2.GetLength(1)];

//     }
//     else
//     {
//         Console.WriteLine("The number of columns of the first matrix and rows of the second matrix must be the same for matrix multiplication. Enter new data to calculate");
//     }
//     return result;
// }


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// (multiplicationOfMatrixes);

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
    {       
        if (matrix1.GetLength(0) != matrix2.GetLength(1))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
 
        var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
 
        for (var i = 0; i < matrix1.GetLength(0); i++)
        {
            for (var j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
 
                for (var k = 0; k < matrix2.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
 
        return matrix3;
    }