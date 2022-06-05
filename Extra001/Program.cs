// Напишите программу вычисления модуля числа. 
// 2 -> 2
//-3 -> 3
// -7 -> 7

Console.WriteLine("Enter your number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0)
{
    Console.Write("module of your number = ");
    Console.WriteLine(numberA);
}
else 
{ 
    Console.Write("module of your number = ");
    Console.WriteLine(-numberA);
}