// Проверка на четность
Console.WriteLine("ВВедите положительное число");
string input;
input = Console.ReadLine();
int userInput;
userInput = int.Parse(input);

if (userInput % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}