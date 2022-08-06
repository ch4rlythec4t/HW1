// Вводим  число
Console.WriteLine("Введите целое число");
int Num = Convert.ToInt32(Console.ReadLine());

//Проверяем диапазон от 1 до Num на четность и выводим четные значения
for (int i = 1; i <= Num; i++)
{
    if ((i % 2) == 0)
    {
        Console.Write($"{i} ");
    }
}