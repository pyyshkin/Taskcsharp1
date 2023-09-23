
Console.WriteLine("Введите три числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) 
{
    if (number1 > number3) 
    {
        int max=number1;
        Console.WriteLine($"{number1}");
    }   
}
else if (number2>number3)
{
   int max=number2;
   Console.WriteLine($"{number2}");    
}
else
{
    int max=number3;
    Console.WriteLine($"{number3}");
}

