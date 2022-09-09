// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
int ferstdig = num / 10000;
int ceconddig = num / 1000 % 10;
int fourthDig = num / 10 % 10;
int fifthGig = num % 10;

if (num>=10000 && num<=99999)
    if (ferstdig == fifthGig)
    {
        if (ceconddig == fourthDig)
        System.Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {num} НЕ является палиндромом");
    }
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}