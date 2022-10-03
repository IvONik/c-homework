// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int FindSumm (int m, int n)
{
    if (m>n)
    {
        return 0;
    }
    else
    {
        return m+FindSumm(m+1,n);
    }

}
System.Console.WriteLine(FindSumm(2,6));