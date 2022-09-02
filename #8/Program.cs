// Четные числа от 1 до N
System.Console.WriteLine("Введите число");
string N = Console.ReadLine();
int n = int.Parse(N);

for (int i=0; i<=n; i++)
if (i%2==0)
{
System.Console.WriteLine(i);
}

