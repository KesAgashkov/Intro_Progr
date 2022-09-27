// // 1. вид методов. Ничего не принимают и ничего не возвращают
// // 2. вид. Принимают аргументы но ничего не возвращают. (void методы)
// // 3. вид. Что-то возвращают. но ничего не принимают
// // 4. вид. Что-то принимают и что-то возвращают

// // 1 вид
// void Method1()
// {
//     System.Console.WriteLine("Автор Агашков К.Н.");
// }
// // Method1(); // вызываем метод

// // 2 вид

// void Method2 (string msg) //на вход можно подавать больше одной переменной через запятую с указанием формата
// {
//     System.Console.WriteLine(msg);
// }
// // Method2("Какой-то текст"); // можем через запятую указывать в этом поле значение для нескольких переменных
// // без соблюдения порядка писать переменные так Method2(msg: "Какой-то текст" , N: 10) или вначале N

// // 3 вид . Обяз указываем тип данные которве метод возвр
// // int Method3()
// // {
// //     return DataTime.Now.Year;
// // }
// // int year = Method3;
// // System.Console.WriteLine(year);

// // 4 вид.
// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
    
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string S = Method4(10, "asdf");
// System.Console.WriteLine(S);

// Цикл FOR

// string Method4 (int count, string text)
// {

//     string result = String.Empty;
    
//     for (int i = 0; i < count; i++) // 1.инициализация счетчика(место старта), 2.условие. 3. инкремент
//     {
//         result = result + text;
//     }
//     return result;
// }
// string S = Method4(10, "asdf");
// System.Console.WriteLine(S);

// Сделаем таблицу умножения
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

// Задача. Дан текст. В нем нужно все пробелы заменить черточками, мал k заменить на K
// большие С заменить на с. Работает.

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else  result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace ("зафиксироСССванная на какоСССм-либо материальном носителе человеческая мысль; в общем плане связная и полная последовательность символов", ' ' , '-' );
// System.Console.WriteLine(newText);

// System.Console.WriteLine();
// newText = Replace(newText, 'к' , 'К');
// System.Console.WriteLine(newText);

// System.Console.WriteLine();
// newText = Replace(newText, 'С' , 'с');
// System.Console.WriteLine(newText);


// Задача. Сортировка от элементов в массиве от мин до макс по порядку
 int[] arr = {1, 5, 3, 7, 9, 4, 8, 1, 3};

 void PrintArr (int[] arr) // выводим массив на экран
 {
    int count = arr.Length;
    
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
 }

void SelectionSort(int[] arr)
{

    for (int i = 0; i < arr.Length - 1 ; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr [j] < arr [minPos]) minPos = j; //ищем мин элемент
        }

        int temporary = arr[i]; // замена эл местами
        arr[i] = arr[minPos];
        arr [minPos] = temporary;
    }
}
 
 SelectionSort(arr);
 PrintArr(arr);
