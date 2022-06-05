// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 конвертирование строки в число
int square = number * number;
Console.Write("Square of the number = ");
Console.WriteLine(square);