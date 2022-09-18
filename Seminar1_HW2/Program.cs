int a = new Random().Next(1, 101);
int b = new Random().Next(1, 101);
int c = new Random().Next(1, 101);

if ((a > c) && (a > b))
{
    Console.WriteLine("max number a = " + a + " last numbers : " + b + "; " + c);
}
else if (b > c)
{
    Console.WriteLine("max number b = " + b + " last numbers : " + a + "; "  + c);
}
else
{
    Console.WriteLine("max number c = " + c + " last numbers : " + a + "; " + b);
}
// не стабильно рабатает , иногда не выдаёт нужные значения, не могу понять по какой причине.
// использовал "или" вместо "и"


