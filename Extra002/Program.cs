// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.

Console.WriteLine("Enter your number: ");
double numberA = Convert.ToDouble(Console.ReadLine());

numberA = 1 / numberA;
Console.Write("Converted number = ");
Console.WriteLine(numberA);
