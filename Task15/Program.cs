
bool ThisIsWeekend(int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}

bool ValidateDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня нет!");
    return false;
}

Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (ValidateDay(day))
{    
    if (ThisIsWeekend(day))
    {
        Console.WriteLine("Выходной");
    }
    else
    Console.WriteLine("Рабочий");
}