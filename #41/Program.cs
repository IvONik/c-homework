//Пользователь вводит с клавиатуры числа. Посчитайте сколько чисел больше 0 ввел пользователь.
System.Console.WriteLine("Введите числа");
string numbers = Console.ReadLine()!; // Предполагается, что пользователь ввел числа через пробел
string[] array = numbers.Split(" ");
int length = array.Length;
int[] DigitalArray = new int[length];

CreateArray(length);
System.Console.WriteLine(" ");
CheckPozitiv (length);

void CreateArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        DigitalArray[i] = int.Parse(array[i]);
        System.Console.Write($"{DigitalArray[i]}, ");
    }
}


void CheckPozitiv (int length)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (DigitalArray[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Положительных чисел {count}");
}