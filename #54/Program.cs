//  Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

System.Console.WriteLine("Введите количество строк");
int rows=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов");
int columns=int.Parse(Console.ReadLine()!);

int[,] matrix=new int[rows,columns];

 FillArrayMatrix(matrix);
 PrintMatrix (matrix);
 System.Console.WriteLine(" ");
 SortedElementsOfRows (matrix);
 PrintMatrix (matrix);


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
void SortedElementsOfRows (int [,] matrix)
{
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int l = 0; l < columns-1; l++)
        {                           
            if (matrix[i,l]>matrix[i,l+1])
            {
                int temp=matrix[i,l];
                matrix[i,l]=matrix[i,l+1];
                matrix[i,l+1]=temp;
            }   
        }        
    }
}
}

