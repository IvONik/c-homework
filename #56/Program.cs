// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
System.Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArrayMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine(" ");
int [] summ = FindSummOfRows(matrix);
FindRowWithMinSumm (summ);


void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write($"{matrix[i, j],5} ");
        }
        System.Console.WriteLine(" ");
    }
}
int [] FindSummOfRows(int[,] matrix)
{
int []summ=new int[rows];
    for (int i = 0; i < rows; i++)
    {
        summ [i]= 0;
        for (int j = 0; j < columns; j++)
        {
            summ[i] += matrix[i, j];
        }
        System.Console.WriteLine(summ[i]);

    }
    return summ;
}
void FindRowWithMinSumm (int []summ)
{    
    int min=summ[0];
    for (int i = 0; i < rows; i++)
    {
        if (summ[i]<min)
        {
            summ[i]=min;
        }
    }    
    System.Console.WriteLine($"Минимальная сумма в строках: {min}");
}
