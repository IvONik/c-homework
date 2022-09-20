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
//string[] textarray = text.Split(" "); //сщздали текстовый массив
//string[] textarray = new string[text.Length];


//int[] dig = new int[text.Length]; //сщздали цифровой массив 
//int summ = 0;
//for (int i = 0; i < text.Length; i++)
//{
    //dig[i] = int.Parse(textarray.Length[i]); //положили из текстового массива в цифровой
    //summ = summ + dig[i]; 
//}
//System.Console.WriteLine($"Сумма цифр {summ}");

//ломается если после последней цифры ввести пробел