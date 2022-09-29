using System;
int NumberOne(int num, int NumberOfFirstNumbers) // сколько цифр хотим видеть в начале
{
    while (num / Math.Pow(10,NumberOfFirstNumbers) > 1)
    {
        num/=10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine());// 1234265735
if(number < 0 ) number *=-1;
if(number > 99)
{
    int x = number % 100; // получаем два последних числа
    int y = NumberOne(number,2);// получаем два первых числа
    if (x/10 == y%10 && x%10 == y/10);
}
else if(number > 9)
{
    int x = number % 10;
    int y = NumberOne(number,2); // получаем два последних числа!!!
}
else
{
    Console.WriteLine("Введите число больше 9");
}
