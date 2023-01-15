// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());

int A = print(m, n);

Console.WriteLine($"A(m,n) = {A}");

int print(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    
    else
    {
        if (n != 0 && m == 0)
        {
            return print(n - 1, 1);
        }
        else
        {
            return print(n - 1, print(n, m - 1));
        }
    }
    
}