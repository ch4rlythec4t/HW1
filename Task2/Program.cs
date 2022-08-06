// Вводим 1-е число
Console.WriteLine ("Введите 1-е число");
double Num1 = Convert.ToDouble(Console.ReadLine());

// Вводим 2-е число
Console.WriteLine ("Введите 2-е число");
double Num2 = Convert.ToDouble(Console.ReadLine());

// Вводим понятия максимального и минимального числа
double Max = 0;
double Min = 0;

// Сравниваем числа
if (Num1 > Num2)
{
    Max = Num1;
    Min = Num2;

    Console.WriteLine($"Число {Max} больше числа {Min}");
}

else if (Num1 < Num2)
{
     Max = Num2;
     Min = Num1;

     Console.WriteLine($"Число {Max} больше числа {Min}");
}

else if (Num1 == Num2)
{
    Console.WriteLine($"Числа {Num1} и {Num2} равны");
}

// // 2 вариант
// // Вводим 1-е число
// Console.WriteLine ("Введите 1-е число");
// double Num1 = Convert.ToDouble(Console.ReadLine());

// // Вводим 2-е число
// Console.WriteLine ("Введите 2-е число");
// double Num2 = Convert.ToDouble(Console.ReadLine());

// // Сравниваем числа
// if (Num1 > Num2)
// {
//     Console.WriteLine($"Число {Num1} больше числа {Num2}");
// }

// else if (Num1 < Num2)
// {
//      Console.WriteLine($"Число {Num2} больше числа {Num1}");
// }

// else if (Num1 == Num2)
// {
//     Console.WriteLine($"Числа {Num1} и {Num2} равны");
// }