// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Input M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());

int count = print(M, N);

Console.WriteLine(count);

int print(int M, int N)
{
    if (M <= N)
    {
        return M + print(M + 1, N);
    }
    else
    {
        return 0;
    }
}