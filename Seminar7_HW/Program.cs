// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> число с таким адресом в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Задача 47.
void CreateMatrix()
{
    int m = 5;
    int n = 7;
    int maximum = 100;
    int minimum = -100;
    double[,] array = new double [m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
           array[i,j] = Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,2);
           //хитрый рандом для дробей и округление до 2 знаков после запятой
           Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

// CreateMatrix();
// Задача 50.
void DisplayArrayCheckExistNymber (int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < column; j++)
        {
            array [i, j] = new Random().Next(-100,100);
            System.Console.Write($"{array[i,j]}\t ");
        }
            System.Console.WriteLine();
    }   
    System.Console.WriteLine("Введите первый и второй индекс нужного элемента в массиве через enter: ");
    int firstIndex = int.Parse (Console.ReadLine());
    int secondIndex = int.Parse (Console.ReadLine());
    System.Console.WriteLine("Введите введите искомое число: ");
    int neededNum = int.Parse (Console.ReadLine());
    if (array[firstIndex,secondIndex] == neededNum)
    {
        System.Console.WriteLine($"Число {neededNum} есть на позиции с индексом : {firstIndex} ; {secondIndex}");
    } else 
    {
        System.Console.WriteLine($"Искомое число {neededNum} не найдено на позиции с индексом : {firstIndex} ; {secondIndex}");
    }
}
// // DisplayArrayCheckExistNymber (20, 10);
// Задача 52.
void CreateDisplayArray (int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++) 
    {
        for (int j = 0; j < column; j++)
        {
            array [i, j] = new Random().Next(0,100);
            System.Console.Write($"{array[i,j]} \t");
        }
            System.Console.WriteLine(); 
    }
    int resColumn = 0;
    int average = 0;
    for (int k = 0; k < row; k++)
    {
        for (int n = 0; n < row; n++)
        {
             resColumn += array[n,k];
        }
    average = resColumn/row;
    System.Console.WriteLine($"Среднее арифметическое столбца {k + 1} : {average}");
    resColumn = 0;
    average = 0;
    }
}
CreateDisplayArray (7,7);
