// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//  Задача 34
void SearchEven (int size, int min, int max){
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min,max);
        System.Console.WriteLine(array[i] + " | " );
            if (array[i] % 2 == 0){
                count++;
            }
    } 
    System.Console.WriteLine("Количество чётных чисел = " + count);
}
//  SearchEven (5, 100, 1000);

//  Задача 36
void SummEl (int size, int min, int max){
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min,max);
        System.Console.WriteLine("индекс " + i + ": "+ array[i]);
            if (i == 1 || i % 2 == 1){
            sum += array[i];
            }
    } 
    System.Console.WriteLine("Сумма чисел с чётными индексами = " + sum);
  }  
// SummEl (6, -100, 100);

// Задача 38
void DiffMaxMin (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
    array[i] = new Random().Next(min,max);
    System.Console.WriteLine(array[i]);
    }
    int maxx = array[0];
    int minn = array [0];
    for (int j = 0; j < size; j++){
        if (maxx < array[j]){
        maxx = array[j];
        }if (minn > array[j]){
        minn = array[j];
        }
    }   System.Console.WriteLine("максимум : " + maxx);
        System.Console.WriteLine("минимум : " + minn);
        int res = maxx - minn;
        System.Console.WriteLine("разность : " + res);
    } 
// DiffMaxMin (10, 0, 100);