Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int res = a % 10;
Console.WriteLine ($"Последняя цифра {res}");