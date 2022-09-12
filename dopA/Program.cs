// заполняет массив 8 случайными числами. Напишите функцию, которая находит среднее арифметическое чисел в массиве.
int[] array = new int[8];
int length = array.Length;
rdm(length);
average();
//
//System.Console.WriteLine("");
//System.Console.WriteLine(average());


void rdm(int length)
{
    
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
        System.Console.Write($"{array[i]}  ");
    }
}

void average()
{
double summ = 0;
int length = array.Length;
for (int i = 0; i < length; i++)
    {
        summ = summ + array[i];
}

System.Console.WriteLine("");
System.Console.WriteLine($" Среднее арифметическое {summ/length}");
}
