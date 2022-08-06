// Вводим 1-е число
Console.WriteLine("Введите 1-е число");
double Num1 = Convert.ToDouble(Console.ReadLine());

// Вводим 2-е число
Console.WriteLine("Введите 2-е число");
double Num2 = Convert.ToDouble(Console.ReadLine());

// Вводим 3-е число
Console.WriteLine("Введите 3-е число");
double Num3 = Convert.ToDouble(Console.ReadLine());

// Вводим понятия максимального числа
double Max = Num1;

if (Num2 > Max)
{
    Max = Num2;
}

if (Num3 > Max)
{
    Max = Num3;
}

Console.WriteLine($"Макcимальным числом является {Max}");