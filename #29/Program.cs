// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите числа");
string numbers = Console.ReadLine(); // Предполагается, что пользователь ввел числа через пробел
string[] array = numbers.Split (" "); 
int length=array.Length;
int i=0;
while (i<length)
{
    int arr=int.Parse(array[i]);
    System.Console.Write($"{arr}, ");
    i++;
}
