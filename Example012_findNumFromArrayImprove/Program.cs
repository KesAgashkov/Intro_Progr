void FillArray (int[] collection) //Метод заполнения массива
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray (int[] col) // void метод не возвращает данные. Метод печати массива на экран
{
    int count = col.Length;
    int posi = 0;
    while (posi < count)
    {
        System.Console.WriteLine(col[posi]);
        posi++;

    }
}
int IndexOf (int[] collection, int find) //Метод поиска индекса определенного элемента в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если искомого числа нет в массиве в строке появится -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [20]; //создай новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);

System.Console.WriteLine();
int pos = IndexOf (array, 9);
System.Console.WriteLine(pos);