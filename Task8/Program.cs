// Вводим  число
Console.WriteLine("Введите целое число");
int Num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Num; i++)
{
    if ((i % 2) == 0)
    {
        Console.Write($"{i}, ");
    }
}