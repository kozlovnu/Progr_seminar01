//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2)
{
    Console.WriteLine("First number is a square of the second");
}
else 
{
    Console.WriteLine("First number is NOT the square of the second number");
}
    

