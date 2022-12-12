// Цикл, который принимает на вход два числа (А и В) 
// и возводит число А (целое) в натуральную степень В (от 1 и более).
// ! Не использовать функцию Math.Pow

Console.Write("Введите целое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if(B < 1)
{
    Console.WriteLine("Введенное значение B не является натуральным");
}

else
Console.WriteLine();
{
    int degree = 1;
    while(B > 0)
    {
        degree = degree * A;
        B = B - 1;
    } 
    if(A > 0) Console.WriteLine("'A' в степени 'B' = " + (degree));
    if(A < 0) Console.WriteLine("'A' в степени 'B' = " + (-degree));
}



// можно сначала понять, что это за число int pow = (B - 1) и использовать его 
// чтобы обозначить условие pow <  раз перемножить через цикл for 
// а можно просто использовать B вычитать из него 1 
// кажется, похожие методы 
