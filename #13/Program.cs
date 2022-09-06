// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    if (num >= 100 && num < 1000)
    {
       System.Console.WriteLine(num%10);
    } 
    if (num>=1000 && num<10000)
    {
        System.Console.WriteLine((num/10)%10);
    }