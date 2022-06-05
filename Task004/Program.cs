// 

Console.WriteLine("Enter your number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
//int numberB = 0;
int count = - numberA;
Console.Write(count);
Console.Write(", ");
int numberB = - numberA;

if (numberA >0)
{
    while (count < (numberA-1))
    {
        numberB = numberB + 1;
        Console.Write(numberB);
        Console.Write(", ");
        count += 1;
    }
    Console.WriteLine(numberA);
}
else
{
 while (count > (numberA+1))
    {
        numberB = numberB - 1;
        Console.Write(numberB);
        Console.Write(", ");
        count -= 1;
    }
    Console.WriteLine(numberA);   
}