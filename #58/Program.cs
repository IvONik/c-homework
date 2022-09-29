// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

System.Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[rows1, columns1];
FillArrayMatrix(matrix1);
PrintMatrix(matrix1);

System.Console.WriteLine("Введите количество строк второй матрицы");
int rows2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов второй матрицы");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] matrix2 = new int[rows2, columns2];
FillArrayMatrix(matrix2);
PrintMatrix(matrix2);


if (columns1 != rows2)
{
       throw new Exception("число столбцов в первой матрице должно быть равно числу строк во второй");
}

MultiplicationMatrix(matrix1, matrix2);
System.Console.WriteLine("Произведение матриц:");
PrintMatrix(MultiplicationMatrix(matrix1, matrix2));

void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],5} ");
        }
        System.Console.WriteLine(" ");
    }
}
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[rows1, columns2];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    return resultMatrix;
}

