// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Задача 19

void SearPolin(){
System.Console.WriteLine("Введите целое положительное пятизначное число");
int num = int.Parse (Console.ReadLine());
if(num < 100000 && num > 0 && num > 9999){
    string str = num.ToString();
    if (str[0] == str[4] && str[1] == str[3]){
    System.Console.WriteLine("Ура, вы ввели полиндром");
    }else System.Console.WriteLine("Это не полиндром, попробуйте еще раз");
}else System.Console.WriteLine("Ошибка, вы ввели неверное число");
}

// Задача 23
void CubeLine (){
    System.Console.WriteLine("Введите положительное целое число N");
    int num = int.Parse (Console.ReadLine());
    if(num > 0){
         for (int i = 1; i <= num ; i++){
            System.Console.WriteLine("Куб от "+ i + ": "  + Math.Pow(i,3));
         }
    }else System.Console.WriteLine("Вы ввели неверное число");
}

// Задача 21
double SPoints(double ax, double ay, double az, double bx, double by, double bz){
if(ax > -100 && ax < 100 && ay > -100 && ay < 100 && az > -100 && az < 100 && 
    bx > -100 && bx < 100 && by > -100 && by < 100 && bz > -100 && bz < 100){
    double result = Math.Pow((ax - bx), 2 ) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2);
    result = Math.Sqrt(result);
    string textRes = string.Format("Расстояние между точкой A и B : {0}", result);
    System.Console.WriteLine(textRes);
    return result;
} 
else{
    System.Console.WriteLine ("Вы вышли за пределы обозначенного интервала, попробуйте еще раз");
    return  0;
}
}
// SPoints(76, -36, 43, 85, 13, -40);

