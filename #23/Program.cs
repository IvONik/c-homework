// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите число");
int N=int.Parse(Console.ReadLine());

void multipl(int N)
{
    for (int i = 1; i <= N; i++)
    {
        int cube = i * i * i;
        System.Console.WriteLine($"{i} в ^ 3 = {cube}");
    }
}
multipl(N);
