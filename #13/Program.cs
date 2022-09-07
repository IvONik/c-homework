// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    
    while (num > 999)
    {
        num=num/10;
    
        int thirdDigit = num % 10;

        System.Console.WriteLine(thirdDigit);
    }