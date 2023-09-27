
int ThirdNumber(int number)
{
    while (number>999)
    {
        number /=10;
    }
    return number%10;
}
bool ValidateNumber(int number)
{
    if (number<100)
    {
        Console.WriteLine("Нет третьей цифры.");
        return false;
    }
    return true;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (ValidateNumber(number))
{
    Console.WriteLine(ThirdNumber(number));
}