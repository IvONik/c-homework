// задать двумерный массив MxN, заполненный случайными вещественными числами числами
System.Console.WriteLine("Введите количетсво строк");
int rows=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количетсво столбцов");
int columns=int.Parse(Console.ReadLine()!);

double[,] matrix=new double[rows,columns];

FillArrayMatrix(matrix);
PrintMatrix (matrix);

void FillArrayMatrix(double[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j]=Math.Round(new Random().NextDouble() + new Random().Next(-10, 11), 1);
        }
    }
}
void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{matrix[i,j],5} ");
        }
        System.Console.WriteLine(" ");
    }
}