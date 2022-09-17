//int название (без цифры вначале) = (присваиваем) целые числа;
//string f = "хранит строки и предложения";
//float x = 3.5f; целые числа с плавающей запятой (ставим точку);
//bool flag (частое название переменное) = true // false
//double b     то же что и float только большие значения
//char type 'f' ставим один символ, число или буква
//var b = может хранить в себе все значения (сам определяет, что хранить)
//int number = 10;
//System.Console.WriteLine("Привет мир" + number+ number); //Выводит текст в консоль в кавычках или цифры без ковычек или переменные, выводит результат простейших математических операций. + добавляет 
//string n = number.ToString(); //перевод переменной в строку
//System.Console.WriteLine("Введите ваше имя");
//string name = Console.ReadLine(name);
//System.Console.WriteLine("Привет, " + name);
//System.Console.WriteLine("Сколько вам лет?");
//int.Parse перевод строки переменной в число

//if (a > b);
//{
//    System.Console.WriteLine("число а больше числа b");
//}
//else if (a < b)
//{
//     System.Console.WriteLine("число b больше числа a");
//}
//else
//{
//     System.Console.WriteLine("число а равно числу b");
//}
//////////////Задача с поиском числа
System.Console.WriteLine("Мы попали в игру угадай число");
int sec_num = new Random().Next(1, 11);
int attempt = 5;
bool win = false;
while (attempt > 0)
{
    System.Console.WriteLine("Введите число от 1 до 10");
    int use_num = int.Parse(Console.ReadLine());
    System.Console.WriteLine(use_num);
    if (use_num > sec_num)
    {
        System.Console.WriteLine(("Секретное число меньше"));
        attempt--;
    }
    else if (use_num < sec_num) // == оператор сравнения
    {
        System.Console.WriteLine("Секретное число больше");
        attempt--; //вычитание на единицу и присваивается Также команда ++
    }
    else if (use_num == sec_num)
    {
        System.Console.WriteLine("Угадали");
        win = true;
        break; //команда позволяющая завершить цикл преждевременно
    }
}
if (win)
{
    System.Console.WriteLine("Вы победили, приходите еще");
    System.Console.WriteLine("Осталось попыток " + (attempt - 1));
}
else
{
    System.Console.WriteLine("Вы проиграли, секретное число было " + sec_num);
    System.Console.WriteLine("Попробуй еще раз");
}

// проверка четности или нечетности
// int number =12;
//if (number % 2 == 0) четное число
//if (number % 2 == 0) нечетное число
