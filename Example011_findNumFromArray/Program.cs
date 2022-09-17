int [] array = { 1, 2, 3, 7, 5, 6, 7, 8, 9 };
int n = array.Length; //указали длину массива
int find = 7;
int index = 0;
while (index < n)
{
    if (array[index]==find)
        {
            System.Console.WriteLine(index);
            break; //прерываем цикл при нахождении первой 7ки
        }
    index = index + 1;
}