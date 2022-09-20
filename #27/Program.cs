// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

int summ=0;
while(number>0)
{
summ+=number%10;
number=number/10;
}
System.Console.WriteLine($"Сумма цифр {summ}");
