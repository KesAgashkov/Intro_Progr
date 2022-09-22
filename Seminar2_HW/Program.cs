// Задача 10
void Sear ()
{
    System.Console.WriteLine("Введите целое число от 1 до 1000");
    int num = int.Parse (Console.ReadLine());
    if (num>1000 && num<1 && num>99)
    {
        System.Console.WriteLine("Ошибка, введено неверное число");
    }
    else 
    {
        int s = (num/10) % 10;
        System.Console.WriteLine("Вторая цифра во введенном числе: " + s);
    }
  }

// Задача 13
void Thr ()
{
    System.Console.WriteLine("Введите целое число от 1 до 1000000");
    int num = int.Parse (Console.ReadLine());
    if (num>1000000 && num<1)
    {
        System.Console.WriteLine("Ошибка, введено неверное число");
    }
    else if (num < 100)
    {
        System.Console.WriteLine("Третьей цифры нет во введенном числе");
    }
    else 
    {
        System.Console.WriteLine("Третья цифра в сумме " + num.ToString()[2]);
    }
  }

// Задача 15
void Week ()
{
    System.Console.WriteLine("Введите порядковый номер дня недели от 1 до 7");
    int num = int.Parse (Console.ReadLine());
    if (num>7 && num<1)
    {
        System.Console.WriteLine("Ошибка, введен неверный номер недели");
    }
    else if (num <= 5)
    {
        System.Console.WriteLine("Пора работать дружище");
    }
    else 
    {
        System.Console.WriteLine("Расслабься и отдохни уже наконец ");
    }
  }
