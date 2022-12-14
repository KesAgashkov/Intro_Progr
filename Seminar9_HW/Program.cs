// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Задача 64

int SummResult (int n)
{
if (n == 1)
return 1;
else if (n == 0)
return 0;
else
return SummResult (n - 1) + n;
}
// SummResult (5);
// System.Console.WriteLine($"Результат суммирования элементов от N до 1: {SummResult(5)}");

// Задача 66
int SummResultMtoN (int m, int n)
{
if (n == m || n < m || m + 1 == n)
return 0;
else 
return SummResultMtoN (m, n - 1) + (n - 1);
}
// System.Console.WriteLine($"Результат суммирования элементов от M до N: {SummResultMtoN (2,7)}");

// Задача 68