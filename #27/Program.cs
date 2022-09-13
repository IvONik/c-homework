// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число ");// Ввод через пробел
string text = Console.ReadLine()!;
string[] textarray = text.Split(" ");

int summ = 0;

int[] dig = new int[textarray.Length];
for (int i = 0; i < textarray.Length; i++)
{
    dig[i] = int.Parse(textarray[i]);
    //System.Console.Write($"{dig[i]} ");
    summ = summ + dig[i];
}
System.Console.WriteLine($"Сумма цифр {summ}");

//ломается если после последней цифры ввести пробел