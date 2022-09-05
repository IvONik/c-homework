// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трехзначное число");
string digital = Console.ReadLine();
System.Console.WriteLine(digital[1]);


//или

System.Console.WriteLine("Введите трехзначное число");
int number=int.Parse(Console.ReadLine());
System.Console.WriteLine((number/10)%10);
