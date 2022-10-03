// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


string ShowNumbers (int n)
{
    if (n>=1)
    {
    return $"{n} "+ShowNumbers(n-1);
    }
    else
    {
    return string.Empty;
    }
}
System.Console.WriteLine(ShowNumbers(5));