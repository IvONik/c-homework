// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
int firstDig = num / 10000;
int secondDig = num / 1000 % 10;
int fourthDig = num / 10 % 10;
int fifthDig = num % 10;

if (num>=10000 && num<=99999)
    {
        if (firstDig == fifthDig && secondDig == fourthDig)
        {
            System.Console.WriteLine($"Число {num} является палиндромом");
        }
    
        else
        {
        System.Console.WriteLine($"Число {num} НЕ является палиндромом");
        }
    }
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}