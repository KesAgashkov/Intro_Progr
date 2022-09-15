Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine ('+');

Console.SetCursorPosition(xa, yb);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10)
{
    int what = new Random().Next(0, 3); //3 не входит
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
     if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine ("+");
    count++;
}


