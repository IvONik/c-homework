// задайте двумерный массив из целых чисел. Найдите среднее арфметическое в каждом столбце.
System.Console.WriteLine("Введите количетсво строк");
int rows=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количетсво столбцов");
int columns=int.Parse(Console.ReadLine()!);

int[,] matrix=new int[rows,columns];

FillArrayMatrix(matrix);
PrintMatrix (matrix);
System.Console.WriteLine(" ");
double average = FindAverage (matrix);

void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j]=new Random().Next(-10, 11);
        }
    }
}
void PrintMatrix (int[,] matrix)

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
double FindAverage (int [,] matrix)
{
    
    double average=1;
    for (int j = 0; j < columns; j++)
    {
     double summ=0;
        for (int i = 0; i < rows; i++)
        {
            summ=summ+matrix[i,j];                 
        }
        average= Math.Round(summ/rows, 2);
        System.Console.Write($"{average, 5} ");    
    
    }
return average;
}