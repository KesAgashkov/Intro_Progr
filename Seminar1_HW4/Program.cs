System.Console.WriteLine (("Введите любое целое число от 1 до N"));
int num = int.Parse (Console.ReadLine());
int ind = 1 ;
while ( ind  <=  num )
{
    if ( ind % 2 == 0 )
    {
       System.Console.Write(ind + "; ");
       ind++;
    }
       else
       ind++;
}
