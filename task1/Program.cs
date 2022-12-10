// Помещает цифры произвольного числа в целочисленный массив, 
// начиная с маледшего разряда

// 1 создаем переменную 
// 2 вычисляем количество цифр в числе (метод)
// 3 выделение памяти массива размером lenght 
// 4 заполнить массив цифрами 
// 5 вывода массива 

// 2 метод 
// принимает число
// возвращает количество

int GetLengthOfNumber(int val)
{
    int count = 0; // количество цифр
    while(val > 0) // сначала определись с действием, потом услови 
    {   
        val = val / 10;
        count++;
    }
    return count;
}
int N = new Random().Next(1,int.MaxValue); // этот метод может быть с 1, 2 параметрами и без
Console.WriteLine(N);
int length = GetLengthOfNumber(N); // здесь типа данных (int N) писать не надо, ошибка 
// Console.WriteLine(length);
int[] digitsOfNumber = new int[length];
for (int i = 0; i < length; i++)
{
    digitsOfNumber[i] = N % 10; // получение остатка от деления - крайнего числа
    N = N / 10; // "отрезание" этого числа для работы со следующим
}
Console.WriteLine();
for (int i = 0; i < length; i++)
{
    Console.Write(digitsOfNumber[i]);
}
