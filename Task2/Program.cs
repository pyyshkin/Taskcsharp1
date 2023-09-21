
Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1>number2)
{
    int Max = number1;
    Console.WriteLine($"max->{Max}");
}
else
{
    int Max=number2;
    Console.WriteLine($"max->{Max}");
}