// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// ""По желанию""

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Задача 56

void SearchRowSummMin (int row, int column)
{
    int[,] array = new int[row, column];
    int sum = 0;
    int i = 0;
    int min = 0;
    int [] minRow = new int[row];
    for (i = 0; i < row; i++) 
    {
        for (int j = 0; j < column; j++)
        {
            array [i, j] = new Random().Next(0,100);
            System.Console.Write($"{array[i,j]} \t");
            sum += array[i,j];
        }
    System.Console.WriteLine(); 
    minRow[i] = sum;
    sum = 0;
    }
min = minRow.Min();
System.Console.WriteLine($"Найдена строка {Array.IndexOf(minRow, min) +1 } с минимальной суммой элементов : {min}");
}
// SearchRowSummMin (5, 5);

// Задача 54
void ReplaceElementInRowMaxToMin (int row, int column)
{
    int[,] array = new int[row, column];
    System.Console.WriteLine("Изначальная матрица");
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < column; j++)
        {
            array [i, j] = new Random().Next(0,10);
            System.Console.Write($"{array[i,j]} \t");
        }
    System.Console.WriteLine(); 
    }
    System.Console.WriteLine(); 
    int x;
    int cur = 0;
    for (int i = 0; i < row; i++) 
    { 
        cur = 0;
        for (int j = 0; j < column - 1; j++)
        {
            for (int k = j; k < column - 1; k++)
            {
            if (array[i,cur] < array [i,k+1])
            {
                x = array[i,cur];
                array [i,cur] = array[i,k+1];
                array[i,k+1] = x;
            }
            }
        cur++;
        }
    }
    System.Console.WriteLine("Отсортированная матрица");
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < column; j++)
        {
            System.Console.Write($"{array[i,j]} \t");
        }
    System.Console.WriteLine(); 
    }
}
// ReplaceElementInRowMaxToMin (4, 4);

// Задача 60.
void ShowThreeDMassive(int rows, int columns, int depth)
    {
        int[,,] improveMass = new int[rows, columns, depth];

        for (int i = 0; i < improveMass.GetLength(0); i++) 
        { 
            for (int j = 0; j < improveMass.GetLength(1); j++)
            {
                for (int k = 0; k < improveMass.GetLength(2); k++)
                {
                    improveMass [i, j, k] = new Random().Next(0,100);
                    System.Console.Write($"{improveMass[i,j,k]}({i}; {j}; {k}) \t");
                }System.Console.WriteLine(); 
            }System.Console.WriteLine(); 
        }
    }
    // ShowThreeDMassive(3, 3, 3);

    // Задача 58

   void MultipleMatrix (int row1, int column1, int row2, int column2 )
{
    int[,] firstMatr = new int[row1, column1];
    int[,] secondMatr = new int[row2, column2];
    int[,] resultMatr = new int[row2, column2];
if (column1 == row2)
{
    System.Console.WriteLine("Первая матрица:"); 
    for (int i = 0; i < row1; i++) 
    {
        for (int j = 0; j < column1; j++)
        {
            firstMatr[i,j] = new Random().Next(0,10);
            System.Console.Write($"{firstMatr[i,j]} \t");
        }
         System.Console.WriteLine(); 
    }
    System.Console.WriteLine("Вторая матрица:"); 
    for (int i = 0; i < row2; i++) 
    {
        for (int j = 0; j < column2; j++)
        {
            secondMatr[i,j] = new Random().Next(0,10);
            System.Console.Write($"{secondMatr[i,j]} \t");
        }
         System.Console.WriteLine(); 
    }
System.Console.WriteLine("Результирующая матрица: "); 
        for (int i = 0; i < row1; i++) 
        {
            for (int j = 0; j < column2; j++)
            {
                for (int k = 0; k < row2; k++)
                {
                    resultMatr[i,j] += firstMatr[i,k] * secondMatr[k,j];
                }
            }
        }
for (int i = 0; i < row2; i++) 
    {
        for (int j = 0; j < column2; j++)
        {
            System.Console.Write($"{resultMatr[i,j]} \t");
        }
         System.Console.WriteLine(); 
}
}
else System.Console.WriteLine("Ошибка. Для успешного умножения количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы");
}

// MultipleMatrix (2, 2, 2, 2);