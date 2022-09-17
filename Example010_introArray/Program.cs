int Max(int arg1, int arg2, int arg3) //Функция - поиск максимума из трех
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//int a1 = 5;
//int b1 = 9;
//int c1 = 2;
//int a2 = 19;
//int b2 = 666;
//int c2 = 49;
//int a3 = 226;
//int b3 = 23;
//int c3 = 41; или можем задать массив

int[] array = { 1, 2, 3, 44, 5, 333, 7, 93, 9 };

//if (b1 > max) max = b1;
//if (c1 > max) max = c1; можно через метод

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

//int max = Max (max1, max2, max3); // или
int result = Max(
    Max(array [0], array [1], array [2]),
    Max(array [3], array [4], array [5]),
    Max(array [6], array [7], array [8])
);


//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

System.Console.WriteLine(result);