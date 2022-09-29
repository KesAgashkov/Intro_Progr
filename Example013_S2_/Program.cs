// начала функций
// void int string bool ... void -пустота (ничего не отдает)
// void WriteTwo() // простейшая функция
// {
//     System.Console.WriteLine(2);
// }
// void WriteHello(string name)
// {
//     System.Console.WriteLine("hello, " + name);
// }
// void WriteHello Console.ReadLine();
// Массивы
// int[] numbers = new int[10];
// int[] a = { 5, 5, 7, 10, 15 };       



int[] crArray (int size)
{
    int[] array = new int [size]; // создаем массив
    for (int i = 0; i < size; i++)// заполнили массив
    {
        array[i] = i;
    }
    return array; // отдать массив
}
void writeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array [i] + "  ");
    }
}
int [] numbers = crArray (15);
writeArray(numbers);
 // выводим массив!!!
