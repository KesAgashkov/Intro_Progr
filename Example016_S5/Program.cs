// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(",");
// int index = new Random().Next(0,nums.Length);
// Console.WriteLine(nums[index]);
// выбираем рандомное слово из ряда слов или чисел

// Задача. Пишем программу которая заменяет положительные числа в массиве на отрицательные и наоборот

int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
// int[] NumberArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]*=-1;
//     }
//     return array;
// }
// int[] array = CreatorArray(8,-10,11);
// Console.WriteLine(String.Join(" ",array));
// array = NumberArray(array);
// Console.WriteLine(String.Join(" ",array));

// Задача. Ищем число в массиве
// bool FindNumber(int number, int[] array)
// {
//     foreach (var item in array)
//     {
//         if(item == number) 
//         {
//             return true;
//         }
//     }
//     return false;
// }
// int[] array = CreatorArray(8,-10,11);
// Console.WriteLine(String.Join(" ",array));
// Console.WriteLine(FindNumber(1,array));

// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int[] CreatorArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }
// CreatorArray(123, -100, 100);


// void PowAtoB (){
//     System.Console.WriteLine("Введите целое положительное число");
//     int a = int.Parse (Console.ReadLine());
//     System.Console.WriteLine("Введите целое число");
//     int res = 1;
//     int b = int.Parse (Console.ReadLine());
//     for (int i = 1; i <= b; i++){
//         res = res * a;
//     }
//     System.Console.WriteLine(a + " в степени " + b + " = " + res);
// }

// // Задача 27
// void SummNum (){
//     System.Console.WriteLine("Введите целое число");
//     int num = int.Parse (Console.ReadLine());
//     int last = 0;
//     if (num > 0)
//     {
//         while(num > 0){
//         last = last + (num % 10);
//         num = num/10;
//         }
//     } else
//         while(num < 0){
//         last = last + ((num * -1) % 10);
//         num = num/10;
//     }
//     System.Console.WriteLine("Cумма всех цифр в числе = " + last);
// }

// // Задача 29
// void FillShow (int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max);
//         System.Console.Write(array[i] + " ,");
//     }
// }
