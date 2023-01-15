// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());

print(N);

void print(int n)
{
    if (n >= 1)
    {
        Console.Write($"{n} ");
        print(n - 1);
    }
}