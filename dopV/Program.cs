//  Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая проверяет, верно ли, что все числа в массиве чётные. 
//Наличие хотя бы одного нечётного числа означает, что ответ — нет.

//исправить ошибку оформления второо метода!!

int[] array = new int[8];
int length = array.Length;

rdm(length);
element(length);

//System.Console.WriteLine()

void rdm(int length)
{

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
        System.Console.Write($"{array[i]}  ");
    }
}



System.Console.WriteLine(" ");

void element(int length)
{
double[] element = new double[array.Length];
int count1 = 0;

for (int i = 0; i < length; i++)
{
    element[i] = array[i] % 2;
    System.Console.Write(element[i]);

        if (element[i] == 0)
        {
            count1 = count1++;
        }
}
System.Console.WriteLine(" ");
    if (count1 == 8)
    {
        System.Console.WriteLine("Все элементы четные");
    }
    else
    {
        System.Console.WriteLine("есть нечетные элементы");
    }
}
