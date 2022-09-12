// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);


double exponentiation(int a, int b)
{
    double exponen = Math.Pow(a, b);
    return exponen;
}
double exponentiation1 = exponentiation(a, b);
System.Console.WriteLine($"Число {a} в степени {b} равно {exponentiation1}");