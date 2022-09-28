// See https://aka.ms/new-console-template for more information
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m1, int n1)
{
    int res = m1;
    if (m1 == n1) return res;
    return res += SumNumbers(m1 + 1, n1);
}
int result = SumNumbers(m, n);
Console.Write(result);