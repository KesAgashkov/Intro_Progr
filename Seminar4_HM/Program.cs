void PowAtoB (){
    System.Console.WriteLine("Введите целое положительное число");
    int a = int.Parse (Console.ReadLine());
    System.Console.WriteLine("Введите целое число");
    int res = 1;
    int b = int.Parse (Console.ReadLine());
    for (int i = 1; i <= b; i++){
        res = res * a;
    }
    System.Console.WriteLine(a + " в степени " + b + " = " + res);
}

// Задача 27
void SummNum (){
    System.Console.WriteLine("Введите целое число");
    int num = int.Parse (Console.ReadLine());
    int last = 0;
    if (num > 0)
    {
        while(num > 0){
        last = last + (num % 10);
        num = num/10;
        }
    } else
        while(num < 0){
        last = last + ((num * -1) % 10);
        num = num/10;
    }
    System.Console.WriteLine("Cумма всех цифр в числе = " + last);
}

// Задача 29
void FillShow (int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min,max);
        System.Console.Write(array[i] + ", ");
    }
}
// Задача 29
FillShow (8 , -10, 10);