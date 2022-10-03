// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int FindAkkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    if (n==0)
    {
        return FindAkkerman((m-1),1);
    }
    else
    {
        return FindAkkerman((m-1),FindAkkerman(m,n-1));
    }
}
System.Console.WriteLine(FindAkkerman(2,3));