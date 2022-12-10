// Программа принимает на вход число
// и выдает сумму цифр в числе, которые являются делителями этого числа
// не использовать для получения цифр числа операцию приведения числа к строке

// проверить и сразу прибавить к сумме 

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

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int lastDigit = N % 10;
int Nremain = N; // N remain — остающееся после отбрасывания последней цифры число
int length = GetLengthOfNumber(N); // количество цифр в числе

for (int i = 0; i < length; i++) // перебор всех цифр
{
    if(lastDigit != 0) // на случай, если цифра будет 0, делить на 0 нельзя
    {
        if(N % lastDigit == 0) // проверка на соответствие характеристике делителя
        {
            sum = sum + lastDigit; // добавляем в сумму 
        }
        Nremain = Nremain / 10; // отбрасываем последнюю цифру
        lastDigit = Nremain % 10; // находим последнюю цифру нового числа 
    }
}
Console.WriteLine("Сумма всех цифр-делителей введённого числа: " + sum);
Console.WriteLine();

