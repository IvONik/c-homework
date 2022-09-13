// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число ");// Ввод через пробел
string text = Console.ReadLine()!;
string[] textarray = text.Split(" "); //сщздали текстовый массив

int summ = 0;

int[] dig = new int[textarray.Length]; //сщздали цифровой массив
for (int i = 0; i < textarray.Length; i++)
{
    dig[i] = int.Parse(textarray[i]); //положили из текстового массива в цифровой
    summ = summ + dig[i];
}
System.Console.WriteLine($"Сумма цифр {summ}");

//ломается если после последней цифры ввести пробел