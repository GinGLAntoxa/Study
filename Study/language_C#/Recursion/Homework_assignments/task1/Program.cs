//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

static void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }
}
Console.WriteLine("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);