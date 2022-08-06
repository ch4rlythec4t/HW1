// Вводим  число
Console.WriteLine("Введите число");
double Num = Convert.ToDouble(Console.ReadLine());

// Проверяем число на четность
if ((Num % 2) == 0)
{
    Console.WriteLine($"Число {Num} четное");
}
else
{
    Console.WriteLine($"Число {Num} нечетное");
}