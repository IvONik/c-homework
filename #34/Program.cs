// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
System.Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine()!);

int[] arrayDig = new int[size];

createArray(size);
System.Console.WriteLine(" ");
int count = showEven(size);

void createArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        arrayDig[i] = new Random().Next(100, 999);
        System.Console.Write($"{arrayDig[i]} ");
    }
}

int showEven(int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arrayDig[i]%2==0)
        {
            count = count+1;
        }
    }
    System.Console.Write(count);
    return count;
}