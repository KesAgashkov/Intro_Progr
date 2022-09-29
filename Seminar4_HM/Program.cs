// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Задача 25 считаем без MathPow

void PowAtoB (){
    System.Console.WriteLine("Введите целое положительное число");
    int a = int.Parse (Console.ReadLine());
    System.Console.WriteLine("Введите целое число");
    int res = 0;
    int b = int.Parse (Console.ReadLine());
    for (int i = 2; i <= b; i++){
        res = res + a * a;
    }
    System.Console.WriteLine(a + " в степени " + b + " = " + res);
}
PowAtoB ();
// Не очень понятно, для чего в этой задаче указано. что необходимо делать через цикл. Ввели два значения, посчитали результат.
// В примере к задаче уточнений не видел. Может нужно перебрать все значения а включая введенное а. и все значения b включая введенное b.
// Если не так сделал, прокомментируйте пож, я переделаю

// Задача 27
void SummNum (){
    System.Console.WriteLine("Введите целое число");
    int num = int.Parse (Console.ReadLine());
    int last = 0;
    if (num > 0)
    {
        while(num > 0){
        last = last + (num % 10);
        num = num/10;
        }
    } else
        while(num < 0){
        last = last + ((num * -1) % 10);
        num = num/10;
    }
    System.Console.WriteLine("Cумма всех цифр в числе = " + last);
}


// Задача 29

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


