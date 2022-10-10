// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

void CreateMatrix()
{
    System.Console.WriteLine("Введите количество строк");
    int line = int.Parse (Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    int column = int.Parse (Console.ReadLine());
    int[,] array = new int [line,column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array [i,j] = i + j;
            System.Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

// Задача. Выбрать элементы с чётными индексами и возвести их в квадрат.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

//Задача. Перебрать элементы массива по диагонали и сложить их (от верхнего угла ровно)
int rows=7;
int columns=5;

int len = rows < columns ? rows : columns;

int[,] array = GetArray(rows, columns);
PrintArray(array);
int sum = 0;
for (int i = 0; i < len; i++) 
{
    sum += array[i,i];
}
System.Console.WriteLine("Готовый вариант");
PrintArray(array);

//функция получения рандома для double
double GetRandomNumber(double minimum, double maximum)
{
    return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,1);
}
