// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 41
void DiffMaxMin (int size)
{ 
    System.Console.WriteLine("Заполните массив целыми числами через enter от -100 до 100");
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
    array[i] = int.Parse (Console.ReadLine());
        if (array[i] < -100 || array[i] > 100)
        {
        System.Console.WriteLine("Вы ввели неверное число, нужно попасть в интервал");
        array[i] = int.Parse (Console.ReadLine());
        }if (array[i] < -100 || array[i] > 100)
        {
            System.Console.WriteLine("Поздравляю, вы таки все сломали");
            break;
        }if (array[i] > 0)
        {
        count++;
        }
    System.Console.WriteLine($"{i+1} элемент массива: " + array[i]);
    }
if (count ==1)
{
    System.Console.WriteLine($"Пользователь ввёл {count} положительное число");
}else if (count < 5 && count > 1)
{
    System.Console.WriteLine($"Пользователь ввёл {count} положительных числа");
}else
{
System.Console.WriteLine($"Пользователь ввёл {count} положительных чисел");
}
}
// DiffMaxMin (5);

// Задача 43
void IntersectionPoints()
{
System.Console.WriteLine("Задайте последовательно через enter переменные k1,b1,k2,b2. Используйте целые числа");
int k1 = int.Parse (Console.ReadLine());
int b1 = int.Parse (Console.ReadLine());
int k2 = int.Parse (Console.ReadLine());
int b2 = int.Parse (Console.ReadLine());
 float x = 0;
 float y = 0;
System.Console.WriteLine($"Введенные переменные: k1 = {k1}; b1= {b1}; k2 = {k2}; b2 = {b2}");
if (k1 != k2)
{
    x = (float)(b2-b1)/(k1-k2);
    y = (float)(k1*(b2-b1))/(k1-k2)+b1;
    System.Console.WriteLine($"Координаты пересечения двух прямых: X = {Math.Round(x,2)} ; Y = {Math.Round(y,2)}");
}else if (k1==k2 && b1==b2)
{
    System.Console.WriteLine("Две прямые совпадают");
} else if (k1==k2)
{
    System.Console.WriteLine("Две прямые параллельны");
}
}
IntersectionPoints();