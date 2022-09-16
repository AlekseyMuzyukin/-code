// 0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Console.Write(" Ввведите целое число: ");
//int number = Convert.ToInt32(Console.ReadLine ());
//int square = number * number;
//Console.WriteLine ($"Квадрат числа{number}={square}");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int sqr = b * b;
if (sqr == a)
{
    Console.Write($"да ,первое число {a} является квадратом второго числа {b}");
}
else 
{
    Console.Write($"нет, первое число {a} не является квадратом второго числа {b}");
}
