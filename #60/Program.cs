// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

System.Console.WriteLine("Введите первый размер");
int depth = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второй размер");
int rows = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите третий размер");
int columns = int.Parse(Console.ReadLine()!);

int[,,] matrix = new int[depth, rows, columns];
int[] array = FillArrayRandom(matrix);
Fill3DMatrix(array, matrix);
PrintIndexAndElement(matrix);


int[] FillArrayRandom(int[,,] matrix)
{
    int[] array = new int[depth * rows * columns];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            //array[j] = new Random().Next(10, 100);
            if (array[j] == array[i])
            {
                array[j] = new Random().Next(10, 100);
                i--;
            }
        }
    }
    return array;
}
void Fill3DMatrix(int[] array, int[,,] matrix)
{
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[index];
                index++;
            }
        }
    }

}
void PrintIndexAndElement(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.WriteLine($"[{i}.{j}.{k}]={matrix[i, j, k]}");
            }
        }
    }
}

