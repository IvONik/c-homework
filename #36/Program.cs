// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
System.Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine()!);

int[] arrayDig = new int[size];

createArray(size);
System.Console.WriteLine(" ");
int summ=findSumm(size);

void createArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        arrayDig[i] = new Random().Next(0, 100);
        System.Console.Write($"{arrayDig[i]} ");
    }
}

int findSumm (int size)
{
    int summ=0;
    for (int i = 1; i < size; i+=2)
    {
        summ=summ+arrayDig[i];
    }
System.Console.WriteLine(summ);
return summ;
}