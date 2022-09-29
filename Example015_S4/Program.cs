// Пример структурного программирования!!!
// int ReadData(string msg) введение числа
// {
//     Console.Write(msg);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int SumDigitOneToA(int numA)
// {
//     int sum = 0;
//     for (int i = 1; i <= numA; i++)
//     {
//         sum = sum + i;
//         //sum += i;
//     }
//     return sum;
// }

// int GaussMethod(int numA)
// {
//     int sum = ((1 + numA) * numA) / 2;
//     return sum;
// }

// DateTime d2 = DateTime.Now;
// int sumGaus = GaussMethod(numA);
// Console.WriteLine(DateTime.Now-d2);

// PrintData("Сумма чисел от 1 до А(gausse): ", sumGaus);
 
 //Пример задачи. Ввести число, показать число, посчитать количество цифр в числе (используем три метода)

//  int ReadData(string msg)
// {
//     System.Console.Write(msg);
//     int number = int.Parse(System.Console.ReadLine());
//     return number;
// }

// void PrintData(string msg, int value)
// {
//     System.Console.WriteLine(msg + value);
// }

// int CountDigitLog(int num)
// {
//     int digitCount = (int)Math.Log10(num) + 1;
//     return digitCount;
// }

// int CountDigitNum(int num)
// {
//     int count = 0;
//     while(num>0)
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }


// int num = ReadData("Введите число = ");

// // int res1 = CountDigitLog(num);
// // int res2 = CountDigitNum(num);
// // PrintData("Количество цифр в числе " + num + " (CountDigitLog) равно = ", res1);
// // PrintData("Количество цифр в числе " + num + " (CountDigitNum) равно = ", res2);

// PrintData("Количество цифр в числе " + num + " (CountDigitLog) равно = ", CountDigitLog(num));
// PrintData("Количество цифр в числе " + num + " (CountDigitNum) равно = ", CountDigitNum(num));

// 28 задача. Напишите программу, которая принимает на вход
//число N и выдаёт произведение чисел от 1 до N.
// 

// Задача 30 Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.

// int ReadData(string msg)
// {
//     System.Console.Write(msg);
//     int number = int.Parse(System.Console.ReadLine() ?? "0");
//     return number;
// }

// int[] Fill1DArr(int len, int lowBord, int highBord)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new System.Random().Next(lowBord, highBord + 1);
//     }
//     return array;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.Write(arr[arr.Length - 1] + "]");
// }

// int arrLen = ReadData("Введите длину массива: ");
// int[] arr = Fill1DArr(arrLen, 0, 1);
// Print1DArr(arr);


