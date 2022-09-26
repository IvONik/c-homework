// на вход принимает позиции элемента в двумерном массиве 
//и возвращает значение этого элемента или пишет, что такого элемента нет.

System.Console.WriteLine("Введите количетсво строк");
int rows=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количетсво столбцов");
int columns=int.Parse(Console.ReadLine()!);

int[,] matrix=new int[rows,columns];

FillArrayMatrix(matrix);
PrintMatrix (matrix);
FindElement(matrix);

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
void FindElement(int[,] matrix)
{
    System.Console.WriteLine("Введите позицию элемента через пробел"); 
    //Обратить внимание, что для пользователья элемент  1 1 это первый элемент
    string index = Console.ReadLine()!;
    string[] indexNum= index.Split (" ");
    int row = int.Parse(indexNum[0]);
    int column = int.Parse(indexNum[1]);
    if(row<=rows || column<=columns)
        {  
            System.Console.WriteLine($"Ваш элемент:{matrix[row-1,column-1]}");
        }
    else
        {
            System.Console.WriteLine("Такого элемента нет");
        }

}
