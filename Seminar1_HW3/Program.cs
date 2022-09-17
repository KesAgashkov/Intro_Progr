System.Console.WriteLine("Введите любое целое число от -100 до 100");
int num = int.Parse (Console.ReadLine());

if ( num % 2 == 0 )
{
    System.Console.WriteLine ("Ура ваше число " + num + " - четное число");
}
else
{
    System.Console.WriteLine ("Сожалею " + num + " - нечетное число");
}
