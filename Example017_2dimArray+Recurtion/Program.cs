// string [,] table = new string [2,5]; //первое число строка, второе число столбец. Матрицы
// table [1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++){
//     for (int col = 0; col < 5; col++){

//         System.Console.WriteLine($"{table[rows, col]}--");

//     }
// }

// Сделаем тоже самое с числами
// int [,] matrix = new int [3,4];   // инициализация массива выделение памяти
// void PrintArra(int [,] matr){
//     for (int i = 0; i < matr.GetLength(0); i++){
//         for (int j = 0; j < matr.GetLength(1); j++){

//             System.Console.Write($"{matr[i, j]} ");

//         }
//     System.Console.WriteLine();
// }
// }

// // и заполним матрицу значениями
// void FillArray(int[,] matr){
// for (int i = 0; i < matr.GetLength(0); i++){
//         for (int j = 0; j < matr.GetLength(1); j++){

//             matr[i,j] = new Random().Next(1,10);

//         }
// }
// }

//Пример рекурсии (ситуация когда функция вызывает сама себя) с поиском Факториала

// double Factor (double n){
// // 1! и 0! равны 1
//     if(n==1) return 1;
//     else return n * Factor(n - 1);
// }
// for (double i = 2; i < 40; i++){
//     System.Console.WriteLine($"{i}! = {Factor(i)}");
// }

// Factor(40);// 3*2*1 = 6