// интересное число - произведение цифр делится на их сумму 
// программа заполняет массив на 10 интересных чисел
// случайно сгенерированных от 10 до 1000

// создаем массив от 10 до 1000
// генерируем случа
// перебираем массив на предмет интересности 
// добавляем этот элемент в массив 

int ProductOfDigit(int N) // метод, который находит произведение цифр
{
    int product = 1; // количество цифр
    int lastDigit = 0;
    while(N > 0) // сначала определись с действием, потом услови 
    {   
        lastDigit = N % 10;
        product = product * lastDigit;
        N = N / 10;
    }
    return product;  
}
int SumOfDigit(int N) // метод, который находит сумму цифр
{
    int sum = 0; // количество цифр
    int lastDigit = 0;
    while(N > 0) // сначала определись с действием, потом услови 
    {   
        lastDigit = N % 10;
        sum = sum + lastDigit;
        N = N / 10;
    }
    return sum;  
}


int length = 10; // ввожу размер массива
int[] array = new int[length];
int interesting = 0;
int i = 0;

Console.Write("[ ");
while(i < length)
{
    interesting = new Random().Next(10, 1001);
    if (ProductOfDigit(interesting) % SumOfDigit(interesting) == 0)
    {
        array[i] = interesting;    
        Console.Write(array[i]);
        i++;
        Console.Write(" ");
    }
}
Console.Write("]");
Console.WriteLine();



